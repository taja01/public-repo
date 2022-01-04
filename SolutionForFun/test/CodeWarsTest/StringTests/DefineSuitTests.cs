using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class DefineSuitTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("clubs", Kata.DefineSuit("3♣"), "Should return clubs with \"3♣\"");
            Assert.AreEqual("spades", Kata.DefineSuit("Q♠"), "Should return clubs with \"Q♠\"");
            Assert.AreEqual("diamonds", Kata.DefineSuit("9♦"), "Should return clubs with \"9♦\"");
            Assert.AreEqual("hearts", Kata.DefineSuit("J♥"), "Should return clubs with \"J♥\"");
        }
    }
}
