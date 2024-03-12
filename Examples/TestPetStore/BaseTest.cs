using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PetStore;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace TestPetStore
{
    public abstract class BaseTest
    {
        public static ILogger<BaseTest> Logger { get; private set; }

        public static IHost Host { get; private set; }

        public static IServiceProvider ServiceProvider { get; private set; }

        public static IHostBuilder HostBuilder { get; private set; }

        public static string EnvironmentName { get; private set; }

        public static IConfigurationRoot Configuration { get; private set; }

        [OneTimeSetUp]
        public void BaseOneTimeSetUp()
        {
            HostBuilder = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder();

            // COMMAND LINE USAGE: dotnet test -v normal -- TestRunParameters.Parameter(name=\\\"environment\\\",value=\\\"DEV\\\")
            var environmentName = TestContext.Parameters["environment"];
            if (string.IsNullOrWhiteSpace(environmentName))
            {
                environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            }

            if (string.IsNullOrWhiteSpace(environmentName))
            {
                environmentName = Environment.GetEnvironmentVariable("environment");
            }

            HostBuilder.UseEnvironment(environmentName);

            IServiceCollection serviceCollection;
            HostBuilderContext hostBuilderContext;
            ILoggingBuilder loggingBuilder;

            var loggerConfiguration = new LoggerConfiguration().Enrich.FromLogContext();

            HostBuilder.ConfigureServices((context, services) =>
            {
                hostBuilderContext = context;
                serviceCollection = services;

                EnvironmentName = hostBuilderContext.HostingEnvironment.EnvironmentName;
                Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true, reloadOnChange: true)
                .Build();

                loggerConfiguration = loggerConfiguration.MinimumLevel.Information();
                loggerConfiguration = loggerConfiguration.MinimumLevel.Information();
                loggerConfiguration = loggerConfiguration.WriteTo.Debug();
                loggerConfiguration = loggerConfiguration.WriteTo.File("log.txt", rollingInterval: RollingInterval.Day);
                loggerConfiguration = loggerConfiguration.WriteTo.Console(theme: AnsiConsoleTheme.Literate);
                loggerConfiguration = loggerConfiguration.ReadFrom.Configuration(Configuration);
                loggerConfiguration = ConfigureLogging(loggerConfiguration);

                Log.Logger = loggerConfiguration.CreateLogger();

                RegisterTestFacilities(serviceCollection);
            });

            HostBuilder.ConfigureLogging((context, builder) =>
            {

                loggingBuilder = builder;
                loggingBuilder.AddSerilog(Log.Logger, true);

            });

            Host = HostBuilder.Build();
            ServiceProvider = Host.Services;

            Logger = ServiceProvider.GetRequiredService<ILogger<BaseTest>>();
            Logger.LogInformation($"*** ENVIRONMENT {EnvironmentName} ***");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Log.CloseAndFlush();
            Host.Dispose();
        }

        protected virtual LoggerConfiguration ConfigureLogging(LoggerConfiguration loggerConfiguration)
        {
            return loggerConfiguration;
        }

        public virtual void RegisterTestFacilities(IServiceCollection serviceCollection)
        {
            serviceCollection.AddPetStoreClient(Configuration);
        }
    }
}
