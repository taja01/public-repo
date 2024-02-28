using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace AsyncToolBoilerTemplate.Services
{
    internal class ParalellExecutionService<TItem>
    {
        private SemaphoreSlim SemaphoreSlim { get; }
        private object SyncRoot { get; }
        public ILogger<ParalellExecutionService<TItem>> Logger { get; }
        public CommandLineOptions Options { get; }

        public ParalellExecutionService(ILogger<ParalellExecutionService<TItem>> logger,
            IOptions<CommandLineOptions> options)
        {
            Options = options.Value;
            SyncRoot = new object();
            SemaphoreSlim = new SemaphoreSlim(Options.NumberOfThreads);
            Logger = logger;
        }

        public async Task Run(IEnumerable<TItem> items, Func<TItem, string> func, Func<TItem, Task> processItem)
        {
            var sum = items.Count();
            var count = 0;
            var itemDurations = new List<double>();

            var tasks = items.Select(async item =>
            {
                await SemaphoreSlim.WaitAsync().ConfigureAwait(false);

                var id = func(item);

                var sw = Stopwatch.StartNew();

                try
                {
                    await Task.Factory
                    .StartNew(async () => await processItem(item).ConfigureAwait(false), CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default)
                    .Unwrap()
                    .ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, "Failed to process item with id: {id}", id);
                }
                finally
                {
                    sw.Stop();

                    SemaphoreSlim.Release();

                    lock (SyncRoot)
                    {
                        ++count;

                        var duration = sw.ElapsedMilliseconds / 1000;
                        itemDurations.Add(sw.ElapsedMilliseconds);
                        var average = TimeSpan.FromMilliseconds(itemDurations.Average());
                        var remainingCount = sum - count;
                        var remainingTime = TimeSpan.FromMilliseconds(remainingCount * average.TotalMilliseconds / Options.NumberOfThreads);


                        Logger.LogInformation(
                            "Thread Id {threadId:D3} Item {id} Duration: {duration:#.00}s - Remaining: {remaining:#.00}.",
                            Thread.CurrentThread.ManagedThreadId,
                            id,
                            duration,
                            remainingCount);
                    }
                }
            }).ToList();

            await Task.WhenAll(tasks).ConfigureAwait(false);
        }
    }
}
