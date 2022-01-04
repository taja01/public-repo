using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class FeastTests
    {
        [TestCase("great blue heron", "garlic naan")]
        [TestCase("chickadee", "chocolate cake")]
        public void BasicTestsTrue(string beast, string dish)
        {
            Assert.IsTrue(Kata.Feast(beast, dish));
        }

        [TestCase("brown bear", "bear claw")]
        public void BasicTestsFalse(string beast, string dish)
        {
            Assert.IsFalse(Kata.Feast(beast, dish));
        }
    }
}
