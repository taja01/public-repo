using OpenQA.Selenium;

namespace SeleniumWebDriverDemo.PageObjects.Google
{
    internal class GoogleMainPage
    {
        private readonly IWebDriver driver;
        public GoogleMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchField => this.driver.FindElement(By.CssSelector("input[name='q']"));
        public IWebElement SearchButton => this.driver.FindElement(By.CssSelector("input[name='btnK']"));
    }
}
