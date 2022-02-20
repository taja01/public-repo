using OpenQA.Selenium;
using PhpTravels.Types;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects
{
    public class Header : AbstractContainer
    {
        public Header(IWebDriver webDriver)
            : base(webDriver, By.CssSelector("header.BS-header"))
        {
        }

        public Element Demo => Find<Element>(By.CssSelector("nav > a:nth-of-type(1)"));
        public Element Pricing => Find<Element>(By.CssSelector("nav > a:nth-of-type(2)"));
        public DropDown Features => Find<DropDown>(By.CssSelector("a[href$='order']+div")); //ask dev to add test-id!
        public Element Docs => Find<Element>(By.XPath("a[href*='docs']"));

        public Element SignIn => Find<Element>(By.CssSelector(".sign-in"));

        public Element SignUp => Find<Element>(By.CssSelector(".signup-free"));


        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.Demo.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Demo missing \n{this.Demo.Path}" };
            }
            if (!this.Pricing.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Pricing missing \n{this.Pricing.Path}" };
            }
            if (!this.Features.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Features missing \n{this.Features.Path}" };
            }
            if (!this.Docs.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Docs missing \n{this.Docs.Path}" };
            }
            if (!this.SignIn.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"SignIn missing \n{this.SignIn.Path}" };
            }
            if (!this.SignUp.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"SignUp missing \n{this.SignUp.Path}" };
            }
            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
