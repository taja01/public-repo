using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class AreEquallyStrongTests
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Kata.AreEquallyStrong(10, 15, 15, 10));
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(Kata.AreEquallyStrong(15, 10, 15, 10));
        }

        [Test]
        public void TestMethod3()
        {
            Assert.IsFalse(Kata.AreEquallyStrong(15, 10, 15, 9));
        }

        [Test]
        public void TestMethod4()
        {
            Assert.IsTrue(Kata.AreEquallyStrong(10, 5, 5, 10));
        }

        [Test]
        public void TestMethod5()
        {
            Assert.IsFalse(Kata.AreEquallyStrong(10, 15, 5, 20));
        }
    }
}
