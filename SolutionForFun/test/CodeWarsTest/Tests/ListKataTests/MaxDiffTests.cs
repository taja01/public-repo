using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class MaxDiffTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(Kata.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 6 }), 6);
            Assert.AreEqual(Kata.MaxDiff(new[] { -0, 1, 2, -3, 4, 5, -6 }), 11);
            Assert.AreEqual(Kata.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 16 }), 16);
            Assert.AreEqual(Kata.MaxDiff(new[] { 16 }), 0);
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(Kata.MaxDiff(new int[] { }), 0);
        }
    }
}
