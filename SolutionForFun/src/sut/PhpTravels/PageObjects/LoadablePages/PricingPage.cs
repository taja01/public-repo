using OpenQA.Selenium;
using PhpTravels.PageObjects.PageComponents.Pricing;
using PhpTravels.RouteBuilder;
using System.Linq;
using Zelenium.Core.Interfaces;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects.LoadablePages
{
    public class PricingPage : AbstractLoadableContainer<Route>
    {
        public PricingPage(IWebDriver webDriver, IRouteBuilder<Route> routeBuilder)
            : base(webDriver, By.CssSelector(".container-price"), routeBuilder, Route.PricingPage)
        {
        }

        public Element BackToDemoLink => Find<Element>(By.CssSelector(".left-side a"));
        public ElementList<Card> Cards => Finds<Card>(By.CssSelector(".pricing"));

        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.BackToDemoLink.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"BackToDemoLink missing \n{this.BackToDemoLink.Path}" };
            }
            if (!this.Cards.Any() || Cards.Count != 4)
            {
                return new ValidationResult { Passed = false, Message = $"Cards missing \n{this.Cards.Path}" };
            }

            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
