using OpenQA.Selenium;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.Types
{
    public class DropDown : AbstractContainer
    {
        public DropDown(IWebDriver webDriver, By locator)
            : base(webDriver, locator)
        {
        }

        public ElementList<Element> MenuItems => Finds<Element>(By.CssSelector(".featuresDropdown a"));

        public override ValidationResult IsLoaded()
        {
            throw new System.NotImplementedException();
        }
    }
}
