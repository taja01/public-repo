using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class FirstDigitTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual('1', Kata.FirstDigit("var_1__Int"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual('2', Kata.FirstDigit("q2q-q"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual('0', Kata.FirstDigit("0ss"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual('2', Kata.FirstDigit("_Aas_23"));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual('9', Kata.FirstDigit("a a_933"));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual('0', Kata.FirstDigit("ok0"));
        }
    }
}
