using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ArrayChangeTests
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Kata.ArrayChange(new int[] { 1, 1, 1 }));
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(5, Kata.ArrayChange(new int[] { -1000, 0, -2, 0 }));
        }
    }
}
