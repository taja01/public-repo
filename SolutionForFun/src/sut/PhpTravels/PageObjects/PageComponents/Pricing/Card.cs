using OpenQA.Selenium;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects.PageComponents.Pricing
{
    public class Card : AbstractContainer
    {
        public Card(IWebDriver webDriver, By locator)
            : base(webDriver, locator)
        {
        }

        public Element Title => Find<Element>(By.TagName(".plan-type"));
        public Element ShortDiscriptionLabel => Find<Element>(By.TagName(".short-description"));
        public Element YearlyPriceLabel => Find<Element>(By.TagName(".show-price.yearly")); //Should be container with currency, price, period
        public Element Button => Find<Element>(By.TagName(".button"));


        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.Title.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Title missing \n{this.Title.Path}" };
            }
            if (!this.ShortDiscriptionLabel.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"ShortDiscriptionLabel missing \n{this.ShortDiscriptionLabel.Path}" };
            }
            if (!this.YearlyPriceLabel.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"YearlyPrice missing \n{this.YearlyPriceLabel.Path}" };
            }
            if (!this.Button.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Button missing \n{this.Button.Path}" };
            }
            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
