using HowToSpecflow.Models;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepDefinitions
{
    [Binding]
    internal sealed class ReturnNullValuesThenSteps : ValidationBase
    {
        [Then(@"'(.*)' user is not registered")]
        public void ThenUserIsNotRegistered(User user)
        {
            Assert.IsNull(user, "User is not null");
            Assert.IsFalse(ScenarioContext.ScenarioContainer.IsRegistered<User>());
        }

        [Then(@"my lucky number is null")]
        public void ThenMyLuckyNumberIsNull()
        {
            var key = "luckyNumber";

            ValidateKey(key);

            Assert.Null(ScenarioContext[key]);
        }

        [Then(@"my lucky date is null")]
        public void ThenMyLuckyDateIsNull()
        {
            var key = "luckyDate";

            ValidateKey(key);

            Assert.Null(ScenarioContext[key]);
        }

        [Then(@"my lucky string is null")]
        public void ThenMyLuckyStringIsNull()
        {
            var key = "luckyString";

            ValidateKey(key);

            Assert.Null(ScenarioContext[key]);

            string a = null;

            Assert.AreEqual(a, ScenarioContext[key]);
            Assert.AreEqual(a?.ToString(), ScenarioContext[key]?.ToString());
        }
    }
}
