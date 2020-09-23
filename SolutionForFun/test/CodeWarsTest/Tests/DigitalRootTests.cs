using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class DigitalRootTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, Kata.DigitalRoot(16));
            Assert.AreEqual(6, Kata.DigitalRoot(456));
            Assert.AreEqual(2, Kata.DigitalRoot(493193));
        }
    }
}