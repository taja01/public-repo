using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class InfectedTests
    {
        double tolerance = 0.00000000001;

        [TestCase(73.33333333333333, "01000000X000X011X0X")]
        [TestCase(72.72727272727273, "01X000X010X011XX")]
        [TestCase(0, "XXXXX")]
        [TestCase(100, "0000000010")]
        [TestCase(42.857142857142854, "X00X000000X10X0100")]
        [TestCase(73.33333333333333, "11111111X000X111X0X")]
        public void Test1(double expected, string pattern)
        {
            Assert.AreEqual(expected, Kata.Infected(pattern), tolerance);
        }
    }
}
