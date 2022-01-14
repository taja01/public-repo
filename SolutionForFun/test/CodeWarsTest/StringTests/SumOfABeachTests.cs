using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class SumOfABeachTests
    {
        [TestCase(1, "SanD")]
        [TestCase(1, "sunshine")]
        [TestCase(4, "sunsunsunsun")]
        [TestCase(1, "123FISH321")]
        public void BasicTests(int expected, string text)
        {
            Assert.AreEqual(expected, Kata.SumOfABeach(text));
        }
    }
}
