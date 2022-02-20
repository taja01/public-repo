using NUnit.Framework;
using OpenQA.Selenium;
using ScreenshotExtension;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.Hooks
{
    [Binding]
    class BeforeAfterStep : Steps
    {
        [AfterStep]
        public void AfterStep()
        {
            if (ScenarioContext.TestError != null)
            {
                var _driver = ScenarioContext.ScenarioContainer.Resolve<IWebDriver>();

                var outputFileName = $"{System.Threading.Thread.CurrentThread.ManagedThreadId}_{DateTime.Now.ToFileTime()}.png";
                var screenshotFilePath = Path.Combine(TestContext.CurrentContext.WorkDirectory, outputFileName);

                _driver.GetFullPageScreenshot(screenshotFilePath);

                Console.WriteLine($"Browser URL: {_driver.Url}");
                TestContext.AddTestAttachment(screenshotFilePath, outputFileName);
            }
        }
    }
}
