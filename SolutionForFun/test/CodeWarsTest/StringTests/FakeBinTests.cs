using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class FakeBinTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("01011110001100111", Kata.FakeBin("45385593107843568"));
            Assert.AreEqual("101000111101101", Kata.FakeBin("509321967506747"));
            Assert.AreEqual("011011110000101010000011011", Kata.FakeBin("366058562030849490134388085"));
        }
    }
}
