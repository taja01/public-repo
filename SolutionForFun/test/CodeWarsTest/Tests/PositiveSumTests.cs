using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    public class PositiveSumTests
    {

        [Test]
        [TestCase(15, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(13, new int[] { 1, -2, 3, 4, 5 })]
        [TestCase(9, new int[] { -1, 2, 3, 4, -5 })]
        [TestCase(0, new int[] { })]
        [TestCase(0, new int[] { -1, -2, -3, -4, -5 })]
        public static void ExampleTest(int result, int[] arr)
        {
            Assert.AreEqual(result, Kata.PositiveSum(arr));
        }
    }
}
