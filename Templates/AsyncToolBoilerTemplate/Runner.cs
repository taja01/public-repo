using AsyncToolBoilerTemplate.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using System.Diagnostics;

namespace AsyncToolBoilerTemplate
{
    internal class Runner
    {
        public string EnvironmentName { get; private set; }
        public ILogger<Program> Logger { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public IConfigurationRoot Configuration { get; private set; }
        public Action<IServiceCollection> ConfigureServices { get; set; }
        public Func<LoggerConfiguration, LoggerConfiguration> ConfigureLogger { get; set; }

        public async Task RunAsync(CommandLineOptions commandLineOptions)
        {
            var sw = new Stopwatch();

            ConfigureHost(commandLineOptions);

            using (var scope = ServiceProvider.CreateScope())
            {
                var type = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(a => a.GetTypes())
                    .Single(t => t.Name.Equals(commandLineOptions.ServiceType, StringComparison.OrdinalIgnoreCase));


                var service = scope.ServiceProvider.GetRequiredService(type) as IRunningService;
                await service.Synchronize();
            }

            Logger.LogInformation("Finished in total: {ellapsedSeconds} seconds", sw.Elapsed.TotalSeconds);
        }

        private void ConfigureHost(CommandLineOptions commandLineOptions)
        {
            var builder = new HostBuilder();
            builder.ConfigureAppConfiguration((context, configurationBuilder) =>
            {
                EnvironmentName = commandLineOptions?.Environment ?? context.HostingEnvironment.EnvironmentName;
                context.HostingEnvironment.EnvironmentName = EnvironmentName;

                try
                {
                    Configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                    .Build();
                }
                catch (Exception e)
                {
                    Configuration = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .Build();
                }
            });

            builder.ConfigureLogging((context, loggingBuilder) =>
            {
                loggingBuilder.ClearProviders();
                var loggerConfiguration = new LoggerConfiguration().Enrich.FromLogContext();

                loggerConfiguration = loggerConfiguration.Enrich.WithThreadId();
                loggerConfiguration = loggerConfiguration.MinimumLevel.Information();
                loggerConfiguration = loggerConfiguration.WriteTo.Debug();
                loggerConfiguration = loggerConfiguration.WriteTo.Trace();
                loggerConfiguration = loggerConfiguration.WriteTo.File("log.txt", rollOnFileSizeLimit: true, fileSizeLimitBytes: 500_000);
                loggerConfiguration = loggerConfiguration.WriteTo.Console(theme: AnsiConsoleTheme.Literate);
                loggerConfiguration = loggerConfiguration.ReadFrom.Configuration(Configuration);

                if (ConfigureLogger != null)
                {
                    loggerConfiguration = ConfigureLogger(loggerConfiguration);
                }

                Log.Logger = loggerConfiguration.CreateLogger();
                loggingBuilder.AddSerilog(Log.Logger, true);
            });

            builder.ConfigureServices(services =>
            {
                services.AddOptions();
                services.AddTransient(typeof(ParalellExecutionService<>), typeof(ParalellExecutionService<>));
                services.AddScoped<IMyService, MyService>();
                services.AddScoped<ITestParallelService, TestService>();

                ConfigureServices?.Invoke(services);

                var options = new CommandLineOptions();

                // From Configuration
                Configuration.Bind(nameof(CommandLineOptions), options);

                services.AddSingleton<IConfiguration>(Configuration);

                // From Command Line
                if (commandLineOptions != null)
                {
                    options.Environment = commandLineOptions.Environment;
                    options.ServiceType = commandLineOptions.ServiceType;
                    options.NumberOfThreads = commandLineOptions.NumberOfThreads;
                }

                services.Configure<CommandLineOptions>(o =>
                {
                    o.Environment = options.Environment;
                    o.ServiceType = options.ServiceType;
                    o.NumberOfThreads = options.NumberOfThreads;
                });

                services.AddSingleton(options);
            });

            var host = builder.Build();
            ServiceProvider = host.Services;
            Logger = ServiceProvider.GetRequiredService<ILogger<Program>>();
            Logger.LogInformation($"{GetType().Assembly.FullName}");

            Logger.LogInformation("Host initialized.");
            Logger.LogInformation("Environment: {environment}.", EnvironmentName);
        }
    }
}
