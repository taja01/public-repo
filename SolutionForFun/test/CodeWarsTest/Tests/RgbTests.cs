using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    public class RgbTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
            Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211));
            Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12));
        }
    }
}
