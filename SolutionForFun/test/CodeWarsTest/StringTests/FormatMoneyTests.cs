using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class FormatMoneyTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("$39.99", Kata.FormatMoney(39.99), "That's not formatted the way we expected.");
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual("$3.00", Kata.FormatMoney(3), "That's not formatted the way we expected.");
        }
    }
}
