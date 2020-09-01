using ClassicSelenium.FrameworkCore.WebDriver;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClassicSelenium.Hooks
{
    [Binding]
    class BeforeAfterScenario : Steps
    {

        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
            var driver = DriverSingleton.Driver;

            driver.Manage().Window.Maximize();
            driver.Url = "https://www.444.hu";
            ScenarioContext.ScenarioContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.ScenarioContainer.IsRegistered<IWebDriver>())
                ScenarioContext.ScenarioContainer.Resolve<IWebDriver>().Quit();
        }
    }
}
