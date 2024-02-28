using Microsoft.Extensions.Logging;

namespace AsyncToolBoilerTemplate.Services
{
    internal class TestService : ITestParallelService
    {
        private ILogger<TestService> Logger { get; }
        private ParalellExecutionService<int> ParalellExecutionService { get; }
        private Random Random { get; }
        public TestService(ILogger<TestService> logger, ParalellExecutionService<int> paralellExecutionService)
        {
            Logger = logger;
            ParalellExecutionService = paralellExecutionService;
            Random = new Random(DateTime.UtcNow.Microsecond);
        }

        public async Task Synchronize()
        {
            var numberOfItems = 100_000;
            var items = Enumerable.Range(0, numberOfItems);

            await ParalellExecutionService.Run(items, item => item.ToString("D3"), Process).ConfigureAwait(false);
        }

        private async Task Process(int item)
        {
            Logger.LogInformation("Working on {i}.", item);
            await Task.Delay(Random.Next(2000, 4000)).ConfigureAwait(false);
        }
    }
}
