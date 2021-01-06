using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class IsInfiniteProcessTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsFalse(Kata.IsInfiniteProcess(2, 6));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Kata.IsInfiniteProcess(2, 3));
        }

        [Test]
        public void Test3()
        {
            Assert.IsFalse(Kata.IsInfiniteProcess(2, 10));
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Kata.IsInfiniteProcess(0, 1));
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Kata.IsInfiniteProcess(3, 1));
        }

        [Test]
        public void Test6()
        {
            Assert.IsFalse(Kata.IsInfiniteProcess(10, 10));
        }

        [Test]
        public void Test7()
        {
            Assert.IsTrue(Kata.IsInfiniteProcess(5, 10));
        }

        [Test]
        public void Test8()
        {
            Assert.False(Kata.IsInfiniteProcess(6, 10));
        }

        [Test]
        public void Test9()
        {
            Assert.IsTrue(Kata.IsInfiniteProcess(10, 0));
        }
    }
}
