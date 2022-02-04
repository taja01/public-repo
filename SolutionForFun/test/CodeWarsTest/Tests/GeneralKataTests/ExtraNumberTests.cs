using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ExtraNumberTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(7, Kata.ExtraNumber(2, 7, 2));
            Assert.AreEqual(3, Kata.ExtraNumber(3, 2, 2));
            Assert.AreEqual(1, Kata.ExtraNumber(5, 5, 1));
            Assert.AreEqual(3, Kata.ExtraNumber(5001, 3, 5001));
        }
    }
}
