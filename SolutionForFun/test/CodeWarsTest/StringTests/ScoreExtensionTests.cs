using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class ScoreExtensionTests
    {
        [TestCase(6, "ABC")]
        [TestCase(96, "Knowledge")]
        [TestCase(98, "Hard Work")]
        [TestCase(0, ".,<>?")]
        [TestCase(0, "")]
        public void TestMethod(int score, string text)
        {
            Assert.AreEqual(score, text.Score());
        }
    }
}
