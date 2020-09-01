
using ClassicSelenium.FrameworkCore.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace ClassicSelenium.Page
{
    internal class MainPage
    {
        public Dictionary<string, IWebElement> dictionary = new Dictionary<string, IWebElement>();
        private readonly IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = ".subhead--widget-stream a")]
        public IWebElement ShowRunnerLabel;

        public MainPage()
        {
            this.driver = DriverSingleton.Driver;
            PageFactory.InitElements(driver, this);
            ElementInitiation();
        }

        private void ElementInitiation()
        {
            dictionary["ShowRunnerLabel"] = ShowRunnerLabel;
        }
    }
}
