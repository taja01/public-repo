using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class GetNumberFromStringTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(1, Kata.GetNumberFromString("1"));
            Assert.AreEqual(123, Kata.GetNumberFromString("123"));
            Assert.AreEqual(7, Kata.GetNumberFromString("this is number: 7"));
            Assert.AreEqual(100000000, Kata.GetNumberFromString("$100 000 000"));
        }
    }
}
