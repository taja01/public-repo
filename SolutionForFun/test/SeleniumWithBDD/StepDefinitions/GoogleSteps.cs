using NUnit.Framework;
using SeleniumWebDriverDemo;
using SeleniumWebDriverDemo.PageObjects.Google;
using System.Linq;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.StepDefinitions
{
    [Binding]
    internal sealed class GoogleSteps : Steps
    {
        private GoogleMainPage GoogleMainPage => ScenarioContext.ScenarioContainer.Resolve<GoogleMainPage>();
        private GoogleResultPage GoogleResultPage => ScenarioContext.ScenarioContainer.Resolve<GoogleResultPage>();

        [Given(@"I am on the google page")]
        public void GivenIAmOnTheGooglePage()
        {
            GoogleMainPage.Load();
        }

        [When(@"I enter '(.*)' to the search field")]
        public void WhenIEnterToTheSearchField(string text)
        {
            GoogleMainPage.SearchField.SendKeys(text);
        }

        [When(@"I hit the search button")]
        public void WhenIHitTheSearchButton()
        {
            GoogleMainPage.SearchButton.Click();
        }

        [Then(@"Search result page is loaded")]
        public void ThenSearchResultPageIsLoaded()
        {
            Assert.IsTrue(GoogleResultPage.IsLoaded(), "Google search result page");
        }

        [When(@"I select from the result which contain '(.*)'")]
        public void WhenISelectFromTheResultWhichContain(string text)
        {
            var result = GoogleResultPage.Results.First(x => x.GetAttribute("href").Contains(text));

            if (result == null)
            {
                throw new TestDataException($"Cannot find result with {text}");
            }

            result.Click();
        }

    }
}
