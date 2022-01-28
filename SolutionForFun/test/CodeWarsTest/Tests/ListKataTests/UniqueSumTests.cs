using CodeWarsTests.ListsKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class UniqueSumTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(6, Kata.UniqueSum(new List<int>() { 1, 2, 3 }));
            Assert.AreEqual(12, Kata.UniqueSum(new List<int>() { 1, 3, 8, 1, 8 }));
            Assert.AreEqual(-1, Kata.UniqueSum(new List<int>() { -1, -1, 5, 2, -7 }));
        }

        [Test]
        public void EmptyTest()
        {
            Assert.Null(Kata.UniqueSum(new List<int>() { }));
        }
    }
}
