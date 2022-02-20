using OpenQA.Selenium;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects.PageComponents.Demo
{
    public class Card : AbstractContainer
    {
        public Card(IWebDriver webDriver, By locator)
            : base(webDriver, locator)
        {
        }

        public Element Banner => Find<Element>(By.CssSelector(".banner-container")); // should be a container 

        public Element Title => Find<Element>(By.TagName("h3"));

        public Element Button => Find<Element>(By.CssSelector(".btn, .app-btn"));

        public Element Text => Find<Element>(By.XPath("//strong/.."));

        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.Banner.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"DemBannero missing \n{this.Banner.Path}" };
            }
            if (!this.Title.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Title missing \n{this.Title.Path}" };
            }
            if (!this.Button.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Button missing \n{this.Button.Path}" };
            }

            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
