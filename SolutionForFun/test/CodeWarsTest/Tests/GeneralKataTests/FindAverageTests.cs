using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class FindAverageTests
    {
        [Test]
        public void ExampleTest()
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Assert.AreEqual(200.0 / 13.0, Kata.FindAverage(array));
        }

        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual(0, Kata.FindAverage(new double[] { }));
        }
    }
}
