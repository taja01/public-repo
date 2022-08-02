using HowToSpecflow.Models;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepDefinitions
{
    [Binding]
    internal sealed class ParsingTableWithValuesThenSteps : Steps
    {
        private Agent SavedAgent => ScenarioContext.ScenarioContainer.Resolve<Agent>();

        [Then(@"agent name is '(.*)'")]
        public void ThenAgentNameIs(object expectedName)
        {
            Assert.AreEqual(expectedName?.ToString(), SavedAgent.Name);
        }

        [Then(@"agent registered date is '(.*)'")]
        public void ThenAgentRegisteredDateIs(DateTime? expectedDateTime)
        {
            Assert.AreEqual(expectedDateTime, SavedAgent.RegisteredDate);
        }

        [Then(@"agent salary is '(.*)'")]
        public void ThenAgentSalaryIs(decimal? expectedDecimal)
        {
            Assert.AreEqual(expectedDecimal, SavedAgent.Salary);
        }

        [Then(@"agent activation is '(.*)'")]
        public void ThenAgentActivationIs(bool? expectedActive)
        {
            Assert.AreEqual(expectedActive, SavedAgent.IsActive);
        }
    }
}
