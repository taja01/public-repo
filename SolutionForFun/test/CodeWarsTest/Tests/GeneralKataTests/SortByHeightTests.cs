using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class SortByHeightTests
    {
        [Test]
        public void Test1()
        {
            CollectionAssert.AreEqual(new[] { -1, 150, 160, 170, -1, -1, 180, 190 }, Kata.SortByHeight(new[] { -1, 150, 190, 170, -1, -1, 160, 180 }));
        }

        [Test]
        public void Test2()
        {
            CollectionAssert.AreEqual(new[] { -1, -1, -1, -1, -1 }, Kata.SortByHeight(new[] { -1, -1, -1, -1, -1 }));
        }

        [Test]
        public void Test3()
        {
            CollectionAssert.AreEqual(new[] { -1 }, Kata.SortByHeight(new[] { -1 }));
        }

        [Test]
        public void Test4()
        {
            CollectionAssert.AreEqual(new[] { 2, 2, 4, 9, 11, 16 }, Kata.SortByHeight(new[] { 4, 2, 9, 11, 2, 16 }));
        }

        [Test]
        public void Test5()
        {
            CollectionAssert.AreEqual(new[] { 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2 }, Kata.SortByHeight(new[] { 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1 }));
        }

        [Test]
        public void Test6()
        {
            CollectionAssert.AreEqual(new[] { 1, 3, -1, 23, 43, -1, -1, 54, -1, -1, -1, 77 }, Kata.SortByHeight(new[] { 23, 54, -1, 43, 1, -1, -1, 77, -1, -1, -1, 3 }));
        }
    }
}