using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class DigitizeTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(new int[] { 1, 2, 3 }, Kata.Digitize(123));
            Assert.AreEqual(new int[] { 1 }, Kata.Digitize(1));
            Assert.AreEqual(new int[] { 0 }, Kata.Digitize(0));
            Assert.AreEqual(new int[] { 1, 2, 3, 0 }, Kata.Digitize(1230));
            Assert.AreEqual(new int[] { 8, 6, 7, 5, 3, 0, 9 }, Kata.Digitize(8675309));
        }
    }
}
