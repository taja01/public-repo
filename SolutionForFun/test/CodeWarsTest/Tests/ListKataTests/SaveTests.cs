using CodeWarsTests.ListsKata;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class SaveTests
    {
        [Test, Description("Calculate number of files")]
        [TestCase(new int[] { 4, 4, 4, 3, 3 }, 12, 3)]
        [TestCase(new int[] { 4, 4, 4, 3, 3 }, 11, 2)]
        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 108, 6)]
        [TestCase(new int[] { 13 }, 13, 1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 250, 4)]
        [TestCase(new int[] { 100 }, 500, 1)]
        [TestCase(new int[] { 11, 13, 15, 17, 19 }, 8, 0)]
        [TestCase(new int[] { 45 }, 12, 0)]
        public void Test(int[] sizes, int hd, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Kata.Save(sizes, hd));
        }
    }
}
