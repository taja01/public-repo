using CodeWarsTests.Tasks.LeetCode;
using NUnit.Framework;

namespace CodeWarsTests.Tests.LeetCodesTests
{
    [TestFixture]
    public class MaxProfixTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, Problems.MaxProfix(new[] { 9, 5, 4, 3, 0 }));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(5, Problems.MaxProfix(new[] { 7, 1, 5, 3, 6, 4 }));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, Problems.MaxProfix(new[] { 1, 2 }));
        }
    }
}
