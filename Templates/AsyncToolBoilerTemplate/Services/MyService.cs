using Microsoft.Extensions.Logging;

namespace AsyncToolBoilerTemplate.Services
{
    internal class MyService : IMyService
    {
        private ILogger<MyService> Logger { get; }
        private CommandLineOptions Options { get; }

        public MyService(ILogger<MyService> logger, CommandLineOptions options)
        {
            Logger = logger;
            Options = options;
        }
        public async Task Work()
        {
            Logger.LogWarning("TODO");
            Logger.LogInformation(Options.Environment);

            await Task.CompletedTask;
        }
    }
}
