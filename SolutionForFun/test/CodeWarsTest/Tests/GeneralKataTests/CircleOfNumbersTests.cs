using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class CircleOfNumbersTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(7, Kata.CircleOfNumbers(10, 2));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, Kata.CircleOfNumbers(10, 7));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(3, Kata.CircleOfNumbers(4, 1));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(0, Kata.CircleOfNumbers(6, 3));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(15, Kata.CircleOfNumbers(18, 6));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(4, Kata.CircleOfNumbers(12, 10));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(14, Kata.CircleOfNumbers(18, 5));
        }
    }
}
