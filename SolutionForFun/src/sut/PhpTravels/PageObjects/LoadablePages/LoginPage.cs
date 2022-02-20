using OpenQA.Selenium;
using PhpTravels.RouteBuilder;
using Zelenium.Core.Interfaces;
using Zelenium.Core.Model;
using Zelenium.Core.WebDriver.Types;

namespace PhpTravels.PageObjects.LoadablePages
{
    public class LoginPage : AbstractLoadableContainer<Route>
    {
        public LoginPage(IWebDriver webDriver, IRouteBuilder<Route> routeBuilder)
            : base(webDriver, By.CssSelector(".header-area +  .container"), routeBuilder, Route.LoginPage)
        {
        }

        public InputField Email => Find<InputField>(By.CssSelector("input[name='email']"));
        public InputField Password => Find<InputField>(By.CssSelector("input[name='password']"));
        public InputField LoginButton => Find<InputField>(By.CssSelector("button[type='submit']"));

        public override ValidationResult IsLoaded()
        {
            if (!this.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Content load failed \n{this.Path}" };
            }
            if (!this.Email.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Email missing \n{this.Email.Path}" };
            }
            if (!this.Password.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"Password missing \n{this.Password.Path}" };
            }
            if (!this.LoginButton.Displayed)
            {
                return new ValidationResult { Passed = false, Message = $"LoginButton missing \n{this.LoginButton.Path}" };
            }

            return new ValidationResult { Passed = true, Message = "Ok" };
        }
    }
}
