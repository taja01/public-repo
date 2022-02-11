using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class FuelPriceTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(5.65, Kata.FuelPrice(5, 1.23));
            Assert.AreEqual(18.40, Kata.FuelPrice(8, 2.5));
            Assert.AreEqual(27.50, Kata.FuelPrice(5, 5.6));
        }
    }
}
