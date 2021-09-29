using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class GrassHopperTests
    {
        [Test]
        public void FirstTest()
        {
            Assert.AreEqual(1, Kata.FindAverage(new[] { 1 }));
        }

        [Test]
        public void SecondTest()
        {
            Assert.AreEqual(4, Kata.FindAverage(new[] { 1, 3, 5, 7 }));
        }

        [Test]
        public void ThirdTest()
        {
            Assert.AreEqual(-5, Kata.FindAverage(new[] { -10, -5, -5, 0 }));
        }

        [Test]
        public void FourthTest()
        {
            Assert.AreEqual(0, Kata.FindAverage(new[] { 0 }));
        }
    }
}
