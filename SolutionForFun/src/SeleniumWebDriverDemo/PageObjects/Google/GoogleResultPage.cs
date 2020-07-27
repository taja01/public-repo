using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumWebDriverDemo.PageObjects.Google
{
    internal class GoogleResultPage
    {
        private readonly IWebDriver driver;
        public GoogleResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IReadOnlyCollection<IWebElement> Results => this.driver.FindElements(By.CssSelector("#rso div.r > a"));
    }
}