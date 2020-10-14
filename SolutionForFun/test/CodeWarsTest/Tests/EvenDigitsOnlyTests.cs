using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class EvenDigitsOnlyTests
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Kata.EvenDigitsOnly(248622));
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsFalse(Kata.EvenDigitsOnly(642386));
        }

        [Test]
        public void TestMethod3()
        {
            Assert.IsFalse(Kata.EvenDigitsOnly(1));
        }
    }
}
