using HowToSpecflow.Models;
using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepDefinitions
{
    [Binding]
    internal sealed class ParsingObjectThenSteps : Steps
    {
        [Then(@"I have one dog object where name is '(.*)', '(.*)' years old")]
        public void ThenIHaveOneDogObjectWhereNameIsYearsOld(string name, int age)
        {
            var savedDog = (Dog)ScenarioContext["singleDog"];

            Assert.AreEqual(name, savedDog.Name, "Name");
            Assert.AreEqual(age, savedDog.Age, "Age");
        }

        [Then(@"the '(.*)'\. dog name is '(.*)', '(.*)' years old")]
        public void ThenThe_DogNameIsYearsOld(int index, string name, int age)
        {
            var dogList = (List<Dog>)ScenarioContext["dogs"];

            Assert.AreEqual(name, dogList[index - 1].Name, "Name");
            Assert.AreEqual(age, dogList[index - 1].Age, "Age");
        }

        [Then(@"user email addres is '(.*)'")]
        public void ThenUserEmailAddresIs(string expectedEmailAddress)
        {
            var savedUser = ScenarioContext.ScenarioContainer.Resolve<User>();

            Assert.AreEqual(expectedEmailAddress, savedUser.Email);
        }

        [Then(@"enum is Dog")]
        public void ThenEnumIsDog()
        {
            var animal = (Animal)ScenarioContext["myAnimal"];

            Assert.AreEqual(Animal.Dog, animal);
        }
    }
}
