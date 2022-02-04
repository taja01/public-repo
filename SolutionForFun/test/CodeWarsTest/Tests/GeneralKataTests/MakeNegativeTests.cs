using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class MakeNegativeTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(-42, Kata.MakeNegative(42));
            Assert.AreEqual(0, Kata.MakeNegative(0));
            Assert.AreEqual(-1, Kata.MakeNegative(-1));
            Assert.AreEqual(-1, Kata.MakeNegative(1));
        }
    }
}
