using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ArrayMaximalAdjacentDifferenceTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Kata.ArrayMaximalAdjacentDifference(new[] { 2, 4, 1, 0 }));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, Kata.ArrayMaximalAdjacentDifference(new[] { 1, 1, 1, 1 }));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(7, Kata.ArrayMaximalAdjacentDifference(new[] { -1, 4, 10, 3, -2 }));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(2, Kata.ArrayMaximalAdjacentDifference(new[] { 10, 11, 13 }));
        }
    }
}
