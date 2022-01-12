using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class UefaEuro2016Tets
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("At match Germany - Ukraine, Germany won!", Kata.UefaEuro2016(new[] { "Germany", "Ukraine" }, new[] { 2, 0 }));
            Assert.AreEqual("At match Belgium - Italy, Italy won!", Kata.UefaEuro2016(new[] { "Belgium", "Italy" }, new[] { 0, 2 }));
            Assert.AreEqual("At match Portugal - Iceland, teams played draw.", Kata.UefaEuro2016(new[] { "Portugal", "Iceland" }, new[] { 1, 1 }));
        }
    }
}
