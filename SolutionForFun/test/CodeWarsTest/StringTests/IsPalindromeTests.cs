using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class IsPalindromeTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(true, Kata.IsPalindrome("anna"));
            Assert.AreEqual(false, Kata.IsPalindrome("walter"));
            Assert.AreEqual(true, Kata.IsPalindrome(12321));
            Assert.AreEqual(false, Kata.IsPalindrome(123456));
        }
    }
}
