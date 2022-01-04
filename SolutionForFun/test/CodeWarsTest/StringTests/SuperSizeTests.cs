using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class SuperSizeTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(96, Kata.SuperSize(69));
            Assert.AreEqual(531, Kata.SuperSize(513));
            Assert.AreEqual(7210, Kata.SuperSize(2017));
            Assert.AreEqual(441, Kata.SuperSize(414));
            Assert.AreEqual(987610, Kata.SuperSize(608719));
            Assert.AreEqual(987654321, Kata.SuperSize(123456789));
            Assert.AreEqual(710000000000, Kata.SuperSize(700000000001));
            Assert.AreEqual(666666, Kata.SuperSize(666666));
            Assert.AreEqual(2, Kata.SuperSize(2));
        }
    }
}
