using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumWebDriverDemo.PageObjects.Wiki
{
    public class WikiPage : AbstractPage
    {
        public WikiPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement Header => this.driver.FindElement(By.Id("firstHeading"));

        public IReadOnlyCollection<IWebElement> HeadLines_3 => this.driver.FindElements(By.CssSelector("h3 .mw-headline"));

        public IReadOnlyCollection<IWebElement> HeadLines_2 => this.driver.FindElements(By.CssSelector("h2 .mw-headline"));

        public override bool IsLoaded()
        {
            return Header.Displayed;
        }
    }
}
