using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ValidParenthesesTests
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Kata.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Kata.ValidParentheses(")(((("));
        }
    }
}