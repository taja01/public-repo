using CodeWarsTests.DateTimeKataTasks;
using NUnit.Framework;

namespace CodeWarsTests.DateTimeKataTests
{
    [TestFixture]
    public class ChineseZodiacTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Wood Snake", DateTimeKata.ChineseZodiac(1965));
            Assert.AreEqual("Earth Tiger", DateTimeKata.ChineseZodiac(1938));
            Assert.AreEqual("Earth Tiger", DateTimeKata.ChineseZodiac(1998));
            Assert.AreEqual("Fire Monkey", DateTimeKata.ChineseZodiac(2016));
            Assert.AreEqual("Wood Rat", DateTimeKata.ChineseZodiac(1924));
            Assert.AreEqual("Earth Monkey", DateTimeKata.ChineseZodiac(1968));
            Assert.AreEqual("Water Dog", DateTimeKata.ChineseZodiac(2162));
        }
    }
}
