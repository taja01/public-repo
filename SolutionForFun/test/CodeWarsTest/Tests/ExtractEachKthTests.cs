using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class ExtractEachKthTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(new[] { 1, 2, 4, 5, 7, 8, 10 }, Kata.ExtractEachKth(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(new int[] { }, Kata.ExtractEachKth(new[] { 1, 1, 1, 1, 1 }, 1));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(new[] { 1, 1, 1, 1 }, Kata.ExtractEachKth(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 2));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, Kata.ExtractEachKth(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 10));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(new[] { 2, 6, 10 }, Kata.ExtractEachKth(new[] { 2, 4, 6, 8, 10 }, 2));
        }
    }
}
