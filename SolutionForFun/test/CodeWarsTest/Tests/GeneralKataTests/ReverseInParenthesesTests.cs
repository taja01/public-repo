using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ReverseInParenthesesTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("rab", Kata.ReverseInParentheses("(bar)"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(string.Empty, Kata.ReverseInParentheses("()"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("cbadgfe", Kata.ReverseInParentheses("(abc)d(efg)"));
        }
    }
}
