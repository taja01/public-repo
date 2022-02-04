using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class PhoneCallTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(14, Kata.PhoneCall(3, 1, 2, 20));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Kata.PhoneCall(2, 2, 1, 2));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(11, Kata.PhoneCall(10, 1, 2, 22));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(14, Kata.PhoneCall(2, 2, 1, 24));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(3, Kata.PhoneCall(1, 2, 1, 6));
        }
    }
}
