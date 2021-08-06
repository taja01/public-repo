using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class SecondMaxIntegerTests
    {
        [Test]
        public void BasicTest()
        {
            var array = new[] { 1, 2, 3, 4 };

            Assert.AreEqual(3, Kata.SecondMaxInteger(array));
        }

        [Test]
        public void MixedTest()
        {
            var array = new[] { -1, 2, -3, 4 };

            Assert.AreEqual(2, Kata.SecondMaxInteger(array));
        }

        [Test]
        public void NegativeNumberTest()
        {
            var array = new[] { -7, -1, 232, -3 };

            Assert.AreEqual(-1, Kata.SecondMaxInteger(array));
        }

        [Test]
        public void SmallGroup()
        {
            var array = new[] { 1, 2 };

            Assert.AreEqual(1, Kata.SecondMaxInteger(array));
        }

        [Test]
        public void ExceptionTest()
        {
            var array = new[] { 1 };

            Assert.Throws<System.Exception>(() => Kata.SecondMaxInteger(array));
        }

        [Test]
        public void NullTest()
        {
            Assert.Throws<System.Exception>(() => Kata.SecondMaxInteger(null));
        }
    }
}
