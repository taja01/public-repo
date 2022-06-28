using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepDefinitions
{
    [Binding]
    internal sealed class ValidateStringSteps : ValidationBase
    {
        [Then(@"my lucky string is '(.*)'")]
        public void ThenMyLuckyStringIs(string expectedValue)
        {
            var key = "luckyString";
            ValidateKey(key);

            var parsedValue = (string)ScenarioContext[key];
            Assert.AreEqual(expectedValue, parsedValue);
        }

        [Then(@"my lucky string is empty")]
        public void ThenMyLuckyStringIsEmpty()
        {
            var key = "luckyString";
            ValidateKey(key);

            var parsedValue = (string)ScenarioContext[key];
            Assert.AreEqual(string.Empty, parsedValue);
        }

    }
}
