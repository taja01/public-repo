using OpenQA.Selenium;

namespace SeleniumWebDriverDemo.PageObjects
{
    public abstract class AbstractPage
    {
        protected readonly IWebDriver driver;

        protected AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public abstract bool IsLoaded();
    }
}
