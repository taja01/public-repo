using OpenQA.Selenium;
using PhpTravels.PageObjects.PageComponents.Demo;
using PhpTravels.RouteBuilder;
using Zelenium.Core.Interfaces;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects.LoadablePages
{
    public class DemoPage : AbstractLoadableContainer<Route>
    {
        public DemoPage(IWebDriver webDriver, IRouteBuilder<Route> routeBuilder)
            : base(webDriver, By.CssSelector("#Main section.grey-box"), routeBuilder, Route.DemoPage)
        {
        }

        public Element SectionTitle => Find<Element>(By.CssSelector(".form-group.text-center"));

        public ElementList<Card> Cards => Finds<Card>(By.CssSelector(".resource-box"));

        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.SectionTitle.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"SectionTitle missing \n{this.SectionTitle.Path}" };
            }

            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
