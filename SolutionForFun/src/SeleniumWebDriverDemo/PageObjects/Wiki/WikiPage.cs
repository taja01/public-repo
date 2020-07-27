using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumWebDriverDemo.PageObjects.Wiki
{
    internal class WikiPage
    {
        private readonly IWebDriver driver;

        public WikiPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Header => this.driver.FindElement(By.Id("firstHeading"));

        public IReadOnlyCollection<IWebElement> HeadLines_3 => this.driver.FindElements(By.CssSelector("h3 .mw-headline"));

        public IReadOnlyCollection<IWebElement> HeadLines_2 => this.driver.FindElements(By.CssSelector("h2 .mw-headline"));
    }
}
