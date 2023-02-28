using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests {

    [TestFixture]
    internal class FindNextSquareTests {

        [TestCase(155, ExpectedResult = -1)]
        [TestCase(121, ExpectedResult = 144)]
        [TestCase(625, ExpectedResult = 676)]
        [TestCase(319225, ExpectedResult = 320356)]
        [TestCase(15241383936, ExpectedResult = 15241630849)]
        public static long SampleTests(long num) {
            return Kata.FindNextSquare(num);
        }
    }
}
