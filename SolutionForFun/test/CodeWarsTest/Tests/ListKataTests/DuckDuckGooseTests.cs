using CodeWarsTests.ListsKata;
using NUnit.Framework;
using System.Linq;
using static CodeWarsTests.ListsKata.Kata;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class DuckDuckGooseTests
    {
        [TestCase(1, "a")]
        [TestCase(3, "c")]
        [TestCase(10, "z")]
        [TestCase(20, "z")]
        [TestCase(30, "z")]
        [TestCase(18, "g")]
        [TestCase(28, "g")]
        [TestCase(12, "b")]
        [TestCase(2, "b")]
        [TestCase(7, "f")]
        public void Test(int goose, string expectedName)
        {
            var exampleNames = new string[] { "a", "b", "c", "d", "c", "e", "f", "g", "h", "z" };
            var players = exampleNames.Select(x => new Player(x)).ToArray();
            string userAns = Kata.DuckDuckGoose(players, goose);
            Assert.AreEqual(expectedName, userAns);
        }
    }
}
