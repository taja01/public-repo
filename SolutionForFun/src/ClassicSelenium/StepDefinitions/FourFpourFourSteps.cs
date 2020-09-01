using ClassicSelenium.Page;
using TechTalk.SpecFlow;

namespace ClassicSelenium.StepDefinitions
{
    [Binding]
    internal sealed class FourFpourFourSteps : Steps
    {
        private MainPage MainPage => ScenarioContext.ScenarioContainer.Resolve<MainPage>();
        [Given(@"I am on 444 site")]
        public void GivenIAmOnSite()
        {
        }

        [When(@"I click ShowRunner label")]
        public void WhenIClickShowRunnerLabel()
        {
            MainPage.ShowRunnerLabel.Click();
        }

        [Then(@"I am on archivum page")]
        public void ThenIAmOnArchivumPage()
        {

        }

    }
}
