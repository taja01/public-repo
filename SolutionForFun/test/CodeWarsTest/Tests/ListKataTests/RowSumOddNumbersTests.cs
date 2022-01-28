using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class RowSumOddNumbersTests
    {
        [TestCase(1, 1)]
        [TestCase(8, 2)]
        [TestCase(27, 3)]
        [TestCase(74088, 42)]
        public void TestMethod(long expected, long row)
        {
            Assert.AreEqual(expected, Kata.RowSumOddNumbers(row));
        }
    }
}
