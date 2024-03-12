using AsyncToolBoilerTemplate.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using Serilog.Sinks.SystemConsole.Themes;
using System.Diagnostics;
using TestDatabase;

namespace TestDatabaseTool
{
    class Runner
    {
        public string EnvironmentName { get; private set; }
        public ILogger<Runner> Logger { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public IConfigurationRoot Configuration { get; private set; }
        public Func<LoggerConfiguration, LoggerConfiguration> ConfigureLogger { get; set; }

        public async Task RunAsync()
        {
            var sw = Stopwatch.StartNew();

            ConfigureHost();

            using (var scope = ServiceProvider.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetRequiredService<MyDbContext>();
                    context.Initialize();
                }
                catch (System.Exception e)
                {
                    Logger.LogCritical(e, "Migrating database failed");
                }

                var service = scope.ServiceProvider.GetRequiredService<IUpdateDatabase>();
                await service.Synchronize();
            }

            Logger.LogInformation("Finished in total: {elapsedSeconds} seconds.", sw.Elapsed.TotalSeconds);
        }

        private void ConfigureHost()
        {
            var builder = new HostBuilder();
            builder.ConfigureAppConfiguration((context, configurationBuilder) =>
            {
                EnvironmentName = context.HostingEnvironment.EnvironmentName;
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

                loggerConfiguration = loggerConfiguration.MinimumLevel.Information();
                loggerConfiguration = loggerConfiguration.WriteTo.Debug();
                loggerConfiguration = loggerConfiguration.WriteTo.Trace();
                loggerConfiguration = loggerConfiguration.WriteTo.File("log.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true, fileSizeLimitBytes: 50000000);
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
                services.AddSingleton<ILoggerFactory, SerilogLoggerFactory>();
                services.AddSingleton(Log.Logger);
                services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
                services.AddScoped<IUpdateDatabase, UpdateDatabase>();

                services.AddOptions();


                services.AddDbContext<MyDbContext>(options =>
                {
                    options.UseSqlServer(
                        Configuration.GetConnectionString(nameof(MyDbContext)),
                        opt => opt.CommandTimeout(60).EnableRetryOnFailure(3));
                    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                });

                // From Configuration
                services.AddSingleton<IConfiguration>(Configuration);
            });

            var host = builder.Build();
            ServiceProvider = host.Services;
            Logger = ServiceProvider.GetRequiredService<ILogger<Runner>>();
            Logger.LogInformation($"{GetType().Assembly.FullName}");

            Logger.LogInformation("Host initialized.");
        }
    }
}
