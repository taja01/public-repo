using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.Hooks
{
    [Binding]
    internal class BeforeAfterScenario : Steps
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenarioSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            ScenarioContext.ScenarioContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenarioTeardown()
        {
            driver.Quit();
        }

    }
}
