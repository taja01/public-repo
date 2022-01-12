using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class HighAndLowTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("5 1", Kata.HighAndLow("1 2 3 4 5"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("9 -5", Kata.HighAndLow("1 9 3 4 -5"));
        }
    }
}
