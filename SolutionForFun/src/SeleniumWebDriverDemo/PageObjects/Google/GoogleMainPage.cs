using OpenQA.Selenium;
using SeleniumWebDriverDemo.PageObjects.Interfaces;

namespace SeleniumWebDriverDemo.PageObjects.Google
{
    public class GoogleMainPage : AbstractPage, ILoadablePage
    {
        public GoogleMainPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement SearchField => this.driver.FindElement(By.CssSelector("input[name='q']"));
        public IWebElement SearchButton => this.driver.FindElement(By.CssSelector("input[name='btnK']"));

        public void Load()
        {
            this.driver.Url = "https://www.google.com/?hl=en";
        }

        public override bool IsLoaded()
        {
            return SearchField.Displayed && SearchField.Displayed;
        }
    }
}
