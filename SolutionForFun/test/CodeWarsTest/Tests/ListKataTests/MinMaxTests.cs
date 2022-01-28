using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class MinMaxTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(new int[] { -1, 20 }, Kata.MinMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            Assert.AreEqual(new int[] { 1, 5 }, Kata.MinMax(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -3, 5 }, Kata.MinMax(new int[] { 1, 2, -3, 4, 5 }));
        }
    }
}
