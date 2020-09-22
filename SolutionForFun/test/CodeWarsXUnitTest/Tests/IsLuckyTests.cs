using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class IsLuckyTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Kata.IsLucky(1230));
        }

        [Test]
        public void Test2()
        {
            Assert.IsFalse(Kata.IsLucky(239017));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Kata.IsLucky(134008));
        }

        [Test]
        public void Test4()
        {
            Assert.IsFalse(Kata.IsLucky(10));
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Kata.IsLucky(11));
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Kata.IsLucky(1010));
        }
    }
}