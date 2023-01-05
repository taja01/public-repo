using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class SecondSmallestTests
    {
        [Test]
        public void NullTest()
        {
            Assert.Null(Kata.SecondSmallest(null));
            Assert.Null(Kata.SecondSmallest(new int[] { }));
            Assert.Null(Kata.SecondSmallest(new int[] { 1 }));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, Kata.SecondSmallest(new int[] { 5, 2, 7, 8, 1, }));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(-4, Kata.SecondSmallest(new int[] { -8, 0, 4, 7, -4 }));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(3, Kata.SecondSmallest(new int[] { 1, 3, 1, 1, 1 }));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(1, Kata.SecondSmallest(new int[] { 0, 1, 0, 1, 0, 1, 0, 1 }));
        }
    }
}
