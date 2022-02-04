using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class GenerateRangeTests
    {
        [Test]
        [TestCase(2, 10, 2, ExpectedResult = new int[] { 2, 4, 6, 8, 10 })]
        [TestCase(1, 10, 4, ExpectedResult = new int[] { 1, 5, 9 })]
        public static int[] FixedTest(int min, int max, int step)
        {
            return Kata.GenerateRange(min, max, step);
        }
    }
}
