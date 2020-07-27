using NUnit.Framework;
using SeleniumWebDriverDemo.PageObjects.Wiki;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.StepDefinitions
{
    [Binding]
    internal sealed class WikiSteps : Steps
    {
        private WikiPage WikiPage => ScenarioContext.ScenarioContainer.Resolve<WikiPage>();

        [Then(@"wikipedia page is loaded")]
        public void ThenWikipediaPageIsLoaded()
        {
            Assert.IsTrue(WikiPage.IsLoaded(), "Wiki page not loaded");
        }

        [Then(@"the title contains '(.*)'s Guide to the Galaxy'")]
        public void ThenTheTitleContainsSGuideToTheGalaxy(string expectedText)
        {
            StringAssert.Contains(expectedText, WikiPage.Header.Text);
        }

        [Then(@"there are more than '(.*)' H3 headline\(s\)")]
        public void ThenThereAreMoreThanH3HeadlineS(int minimum)
        {
            Assert.Greater(WikiPage.HeadLines_3.Count, 0);
        }

        [Then(@"there are more than '(.*)' H2 headline\(s\)")]
        public void ThenThereAreMoreThanH2HeadlineS(int minimum)
        {
            Assert.Greater(WikiPage.HeadLines_2.Count, 0);
        }

    }
}
