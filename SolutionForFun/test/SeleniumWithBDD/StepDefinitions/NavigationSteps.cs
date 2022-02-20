using System;
using System.Linq;
using TechTalk.SpecFlow;
using Zelenium.Core.Interfaces;
using Zelenium.Core.Utils;

namespace SeleniumWithBDD.StepDefinitions
{
    [Binding]
    internal sealed class NavigationSteps : Steps
    {
        [Given(@"I am on the '([^']*)'")]
        public void GivenIAmOnThe(string page)
        {
            var assembly = GetTestPageAssembly();
            var objectType = assembly.GetType($"PhpTravels.PageObjects.LoadablePages.{page}");
            var currentPageObject = ScenarioContext.ScenarioContainer.Resolve(objectType);

            ((ILoadableContainer)currentPageObject).Load();
            ((ILoadableContainer)currentPageObject).WaitForLoad();
        }

        [Then(@"'([^']*)' is loaded")]
        public void ThenIsLoaded(string page)
        {
            var assembly = GetTestPageAssembly();
            var objectType = assembly.GetType($"PhpTravels.PageObjects.LoadablePages.{page}");
            var currentPageObject = ScenarioContext.ScenarioContainer.Resolve(objectType);

            Assertion.IsTrue(((ILoadableContainer)currentPageObject).IsLoaded(), $"Page '{page}' not loaded");
        }

        private static System.Reflection.Assembly GetTestPageAssembly()
        {
            return AppDomain.CurrentDomain.GetAssemblies().First(x => x.FullName.Contains("PhpTravels"));
        }
    }
}
