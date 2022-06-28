using HowToSpecflow.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HowToSpecflow.StepDefinitions
{
    [Binding]
    internal sealed class ParsingObjectGivenSteps : Steps
    {
        [Given(@"I have a dog:")]
        public void GivenIHaveADog(Table table)
        {
            var dog = table.CreateInstance<Dog>();

            ScenarioContext["singleDog"] = dog;
        }

        [Given(@"I have more dogs:")]
        public void GivenIHaveMoreDogs(Table table)
        {
            var dogs = table.CreateSet<Dog>();

            ScenarioContext["dogs"] = dogs;
        }

        [Given(@"I have '(.*)' user")]
        public void GivenIHaveUser(User user)
        {
            if (user != null)
            {
                ScenarioContext.ScenarioContainer.RegisterInstanceAs(user);
            }
        }

        [Given(@"I have a '(.*)' enum")]
        public void GivenIHaveAEnum(Animal animal)
        {
            ScenarioContext["myAnimal"] = animal;
        }

    }
}
