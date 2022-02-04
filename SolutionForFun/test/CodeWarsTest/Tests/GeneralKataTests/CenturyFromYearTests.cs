using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class CenturyFromYearTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(20, Kata.CenturyFromYear(1905));
            Assert.AreEqual(17, Kata.CenturyFromYear(1700));
            Assert.AreEqual(1, Kata.CenturyFromYear(8));
            Assert.AreEqual(1, Kata.CenturyFromYear(45));
            Assert.AreEqual(4, Kata.CenturyFromYear(335));
        }
    }
}