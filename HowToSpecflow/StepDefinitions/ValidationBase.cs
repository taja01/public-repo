using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepDefinitions
{
    internal class ValidationBase : Steps
    {
        protected void ValidateKey(string key)
        {
            Assert.True(ScenarioContext.ContainsKey(key), $"Key '{key}' not exist");
        }
    }
}
