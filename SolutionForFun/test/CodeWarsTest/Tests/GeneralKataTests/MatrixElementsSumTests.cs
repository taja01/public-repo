using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class MatrixElementsSumTests
    {
        [Test]
        public void Test()
        {
            var arr = new int[3][];
            arr[0] = new int[] { 0, 1, 1, 2 };
            arr[1] = new int[] { 0, 5, 0, 0 };
            arr[2] = new int[] { 2, 0, 3, 3 };

            Assert.AreEqual(9, Kata.MatrixElementsSum(arr));
        }
    }
}