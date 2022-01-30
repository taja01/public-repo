using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class ElementsSumTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(16, Kata.ElementsSum(new[] { new[] { 3, 2, 1, 0 }, new[] { 4, 6, 5, 3, 2 }, new[] { 9, 8, 7, 4 } }));
            Assert.AreEqual(15, Kata.ElementsSum(new[] { new[] { 3 }, new[] { 4, 6, 5, 3, 2 }, new[] { 9, 8, 7, 4 } }));
            Assert.AreEqual(7, Kata.ElementsSum(new[] { new[] { 3, 2, 1, 0 }, new[] { 4, 6, 5, 3, 2 }, new int[0] }));
            Assert.AreEqual(12, Kata.ElementsSum(new[] { new[] { 3, 2, 1, 0 }, new[] { 4, 6, 5, 3, 2 }, new int[0] }, 5));
            Assert.AreEqual(0, Kata.ElementsSum(new[] { new[] { 3, 2 }, new[] { 4 }, new int[0] }));
        }
    }
}
