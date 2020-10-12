using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class ArrayReplaceTests
    {
        [Test]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new[] { 3, 2, 3 }, Kata.ArrayReplace(new[] { 1, 2, 1 }, 1, 3));
        }

        [Test]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 0, 4, 5 }, Kata.ArrayReplace(new[] { 1, 2, 3, 4, 5 }, 3, 0));
        }

        [Test]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new[] { 10, 10, 10 }, Kata.ArrayReplace(new[] { 1, 1, 1 }, 1, 10));
        }

        [Test]
        public void TestMethod4()
        {
            CollectionAssert.AreEqual(new[] { 1, 1, 1, 1, 1 }, Kata.ArrayReplace(new[] { 1, 2, 1, 2, 1 }, 2, 1));
        }

        [Test]
        public void TestMethod5()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 1, 2, 1 }, Kata.ArrayReplace(new[] { 1, 2, 1, 2, 1 }, 2, 2));
        }
    }
}
