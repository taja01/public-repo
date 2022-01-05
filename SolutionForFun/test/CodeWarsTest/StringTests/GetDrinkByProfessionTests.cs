using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class GetDrinkByProfessionTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Patron Tequila", Kata.GetDrinkByProfession("jabrOni"), "'Jabroni' should map to 'Patron Tequila'");
            Assert.AreEqual("Anything with Alcohol", Kata.GetDrinkByProfession("scHOOl counselor"), "'School Counselor' should map to 'Anything with alcohol'");
            Assert.AreEqual("Hipster Craft Beer", Kata.GetDrinkByProfession("prOgramMer"), "'Programmer' should map to 'Hipster Craft Beer'");
            Assert.AreEqual("Moonshine", Kata.GetDrinkByProfession("bike ganG member"), "'Bike Gang Member' should map to 'Moonshine'");
            Assert.AreEqual("Your tax dollars", Kata.GetDrinkByProfession("poLiTiCian"), "'Politician' should map to 'Your tax dollars'");
            Assert.AreEqual("Cristal", Kata.GetDrinkByProfession("rapper"), "'Rapper' should map to 'Cristal'");
            Assert.AreEqual("Beer", Kata.GetDrinkByProfession("pundit"), "'Pundit' should map to 'Beer'");
            Assert.AreEqual("Beer", Kata.GetDrinkByProfession("Pug"), "'Pug' should map to 'Beer'");
        }
    }
}
