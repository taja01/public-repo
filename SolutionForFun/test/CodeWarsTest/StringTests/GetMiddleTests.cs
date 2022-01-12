using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class GetMiddleTests
    {
        [TestCase("es", "test")]
        [TestCase("t", "testing")]
        [TestCase("dd", "middle")]
        [TestCase("A", "A")]
        public void GenericTests(string expected, string text)
        {
            Assert.AreEqual(expected, Kata.GetMiddle(text));
        }
    }
}
