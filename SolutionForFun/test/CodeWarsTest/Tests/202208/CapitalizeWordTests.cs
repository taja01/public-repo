using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests._202208
{
    [TestFixture]
    public class CapitalizeWordTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(Kata.CapitalizeWord("word"), "Word");
            Assert.AreEqual(Kata.CapitalizeWord("i"), "I");
            Assert.AreEqual(Kata.CapitalizeWord("glasswear"), "Glasswear");
        }
    }
}
