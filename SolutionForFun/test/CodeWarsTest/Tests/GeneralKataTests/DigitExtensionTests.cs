using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class DigitExtensionTests
    {

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(false, "".Digit());
            Assert.AreEqual(true, "7".Digit());
            Assert.AreEqual(false, " ".Digit());
            Assert.AreEqual(false, "a".Digit());
            Assert.AreEqual(false, "a5".Digit());
            Assert.AreEqual(false, "14".Digit());
        }
    }
}
