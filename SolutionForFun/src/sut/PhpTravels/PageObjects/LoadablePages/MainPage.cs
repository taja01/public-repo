using OpenQA.Selenium;
using PhpTravels.RouteBuilder;
using Zelenium.Core.Interfaces;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects.LoadablePages
{
    public class MainPage : AbstractLoadableContainer<Route>
    {
        public MainPage(IWebDriver webDriver, IRouteBuilder<Route> routeBuilder)
            : base(webDriver, By.CssSelector("#Main .area .container"), routeBuilder, Route.MainPage)
        {
        }

        public Element OverviewDemo => Find<Element>(By.CssSelector(".btn-white"));
        public Element Pricing => Find<Element>(By.CssSelector(".btn-white-outline"));

        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.OverviewDemo.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"OverviewDemo missing \n{this.OverviewDemo.Path}" };
            }
            if (!this.Pricing.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Pricing missing \n{this.Pricing.Path}" };
            }

            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
