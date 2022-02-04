using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class DepositProfitTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Kata.DepositProfit(100, 20, 170));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Kata.DepositProfit(100, 1, 101));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(6, Kata.DepositProfit(1, 100, 64));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(6, Kata.DepositProfit(20, 20, 50));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(4, Kata.DepositProfit(50, 25, 100));
        }
    }
}
