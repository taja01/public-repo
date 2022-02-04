using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class IsIPv4AddressTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Kata.IsIPv4Address("172.16.254.1"));
        }

        [Test]
        public void Test2()
        {
            Assert.IsFalse(Kata.IsIPv4Address("172.316.254.1"));
        }

        [Test]
        public void Test3()
        {
            Assert.IsFalse(Kata.IsIPv4Address(".254.255.0"));
        }

        [Test]
        public void Test4()
        {
            Assert.IsFalse(Kata.IsIPv4Address("1.1.1.1a"));
        }

        [Test]
        public void Test5()
        {
            Assert.IsFalse(Kata.IsIPv4Address("1"));
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Kata.IsIPv4Address("0.254.255.0"));
        }
    }
}
