using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.IO;

namespace TestProjectWithConfig
{
    public abstract class TestSetupBase
    {
        protected static string EnvironmentName { get; private set; }
        protected static IConfigurationRoot Configuration { get; private set; }

        [OneTimeSetUp]
        public void SetupTestRun()
        {
            // COMMAND LINE USAGE: dotnet test -v normal -- TestRunParameters.Parameter(name=\\\"environment\\\",value=\\\"DEV\\\")
            EnvironmentName = TestContext.Parameters["environment"];

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true, reloadOnChange: true)
                .Build();
        }
    }

    //[TestFixture]
    //public class TestServiceSetupBase
    //{
    //    public static string EnvironmentName { get; private set; }
    //    public static IHostBuilder HostBuilder { get; private set; }
    //    public static IConfigurationRoot Configuration { get; private set; }
    //    public static IHost Host { get; private set; }

    //    [OneTimeSetUp]
    //    public void SetupTest()
    //    {
    //        EnvironmentName = TestContext.Parameters["environment"];

    //        HostBuilder = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder();

    //        HostBuilder.UseEnvironment(EnvironmentName);

    //        HostBuilderContext hostBuilderContext;

    //        HostBuilder.ConfigureServices((context) =>
    //        {
    //            hostBuilderContext = context;

    //            Configuration = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettings.json")
    //            .AddJsonFile($"appsettings.{hostBuilderContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    //            .Build();

    //        });

    //        Host = HostBuilder.Build();
    //    }
    //}
}
