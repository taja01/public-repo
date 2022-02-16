using CodeWarsTests.Tasks.LeetCode;
using NUnit.Framework;

namespace CodeWarsTests.Tests.LeetCodesTests
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        public void Test0()
        {
            Assert.Null(Problems.TwoSum(new[] { 2, 7, 11, 15 }, 100));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new[] { 0, 1 }, Problems.TwoSum(new[] { 2, 7, 11, 15 }, 9));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(new[] { 1, 2 }, Problems.TwoSum(new[] { 3, 2, 4 }, 6));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(new[] { 0, 1 }, Problems.TwoSum(new[] { 3, 3 }, 6));
        }
    }
}
