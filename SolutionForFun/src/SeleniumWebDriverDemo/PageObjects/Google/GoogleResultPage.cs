using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumWebDriverDemo.PageObjects.Google
{
    public class GoogleResultPage : AbstractPage
    {

        public GoogleResultPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Logo => this.driver.FindElement(By.Id("logo"));
        public IReadOnlyCollection<IWebElement> Results => this.driver.FindElements(By.CssSelector("#rso div.r > a"));

        public override bool IsLoaded()
        {
            return this.Logo.Displayed;
        }
    }
}