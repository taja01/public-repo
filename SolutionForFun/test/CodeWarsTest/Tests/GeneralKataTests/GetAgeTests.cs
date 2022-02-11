using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class GetAgeTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(3, Kata.GetAge("3 years old"));
            Assert.AreEqual(4, Kata.GetAge("4 years old"));
            Assert.AreEqual(9, Kata.GetAge("9 years old"));
        }
    }
}
