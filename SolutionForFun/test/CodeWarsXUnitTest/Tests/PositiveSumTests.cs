using CodeWarsXUnitTest.Tasks;
using Xunit;

namespace CodeWarsXUnitTest.Tests
{
    public class PositiveSumTests
    {

        [Theory]
        [InlineData(15, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(13, new int[] { 1, -2, 3, 4, 5 })]
        [InlineData(9, new int[] { -1, 2, 3, 4, -5 })]
        [InlineData(0, new int[] { })]
        [InlineData(0, new int[] { -1, -2, -3, -4, -5 })]
        public static void ExampleTest(int result, int[] arr)
        {
            Assert.Equal(result, Kata.PositiveSum(arr));
        }
    }
}
