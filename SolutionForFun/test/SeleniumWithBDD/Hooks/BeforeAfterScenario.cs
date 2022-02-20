using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using PhpTravels.RouteBuilder;
using SeleniumWithBDD.Settings;
using System;
using TechTalk.SpecFlow;
using Zelenium.Core.Interfaces;
using Zelenium.WebDriverManager;

namespace SeleniumWithBDD.Hooks
{
    [Binding]
    internal class BeforeAfterScenario : Steps
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenarioSetup()
        {
            var isDebug = bool.Parse(BeforeAfterTest.Configuration["Debug"]);
            var runMode = Enum.Parse<RunMode>(BeforeAfterTest.Configuration["RunMode"]);
            var browser = Enum.Parse<Zelenium.Shared.Browser>(BeforeAfterTest.Configuration["Browser"]);
            var remoteUrl = BeforeAfterTest.Configuration["RemoteUrl"];

            if (runMode == RunMode.Local)
            {
                _driver = new WebDriverFactory().GetWebDriver(browser, debug: isDebug);
                _driver.Manage().Window.Maximize();
            }
            else
            {
                try
                {
                    _driver = new WebDriverFactory().GetWebDriver(browser, remoteUrl, debug: isDebug);
                    _driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);

                    var allowsDetection = _driver as IAllowsFileDetection;
                    allowsDetection.FileDetector = new LocalFileDetector();
                }
                catch (WebDriverException e)
                {
                    throw new WebDriverException($"Check that docker contains '{browser}' nodes", e);
                }
            }


            ScenarioContext.ScenarioContainer.RegisterInstanceAs(_driver);
            ScenarioContext.ScenarioContainer.RegisterInstanceAs<IRouteBuilder<Route>>(new UrlBuilder());
        }

        [AfterScenario]
        public void AfterScenarioTeardown()
        {
            _driver.Quit();
        }

    }
}
