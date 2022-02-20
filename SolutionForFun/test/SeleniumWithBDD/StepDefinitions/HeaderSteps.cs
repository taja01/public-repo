using PhpTravels.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.StepDefinitions
{
    [Binding]
    internal sealed class HeaderSteps : Steps
    {
        private Header Header => ScenarioContext.ScenarioContainer.Resolve<Header>();

        [When(@"I click Demo button from the header")]
        public void WhenIClickDemoButtonFromTheHeader()
        {
            Header.Demo.Click();
        }

        [When(@"I click Pricing button from the header")]
        public void WhenIClickPricingButtonFromTheHeader()
        {
            Header.Click();
        }

    }
}
