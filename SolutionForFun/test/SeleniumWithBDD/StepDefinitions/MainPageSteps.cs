using PhpTravels.PageObjects.LoadablePages;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.StepDefinitions
{
    [Binding]
    internal sealed class MainPageSteps : Steps
    {
        private MainPage MainPage => ScenarioContext.ScenarioContainer.Resolve<MainPage>();

        [When(@"I click Demo button from the main page")]
        public void WhenIClickDemoButtonFromTheMainPage()
        {
            MainPage.OverviewDemo.Click();
        }
    }
}
