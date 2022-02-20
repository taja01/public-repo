using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.IO;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.Hooks
{
    [Binding]
    internal class BeforeAfterTest : Steps
    {
        internal static string EnvironmentName { get; private set; }
        internal static IConfigurationRoot Configuration { get; private set; }

        [BeforeTestRun]
        public static void BeforeTest()
        {
            EnvironmentName = TestContext.Parameters["environment"];

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true, reloadOnChange: true)
                .Build();
        }
    }
}
