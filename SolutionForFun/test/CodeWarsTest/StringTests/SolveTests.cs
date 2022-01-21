using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class SolveTests
    {
        [TestCase("xyab", "xzca", "ybzc")]
        [TestCase("xyabb", "xzca", "ybbzc")]
        [TestCase("abcd", "xyz", "abcdxyz")]
        [TestCase("xxx", "xzca", "zca")]
        public void TestMethod(string a, string b, string result)
        {
            Assert.That(Kata.Solve(a, b), Is.EqualTo(result));
        }
    }
}
