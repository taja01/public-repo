using System;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepDefinitions
{
    [Binding]
    internal sealed class ReturnNullValuesGivenSteps : Steps
    {
        [Given(@"I have a lucky number '(.*)'")]
        public void GivenIHaveALuckyNumber(int? luckyNumber)
        {
            ScenarioContext["luckyNumber"] = luckyNumber;
        }

        [Given(@"I have a lucky date '(.*)'")]
        public void GivenIHaveALuckyDate(DateTime? luckyDate)
        {
            ScenarioContext["luckyDate"] = luckyDate;
        }

        [Given(@"I have a lucky string '(.*)'")]
        public void GivenIHaveALuckyString(object luckyString)
        {
            ScenarioContext["luckyString"] = luckyString;
        }

    }
}
