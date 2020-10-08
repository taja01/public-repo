using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class AlternatingSortTests
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Kata.AlternatingSort(new[] { 1, 3, 5, 6, 4, 2 }));
        }

        [Test]
        public void TestMethod2()
        {

            Assert.IsFalse(Kata.AlternatingSort(new[] { 1, 4, 5, 6, 3 }));
        }

        [Test]
        public void TestMethod3()
        {

            Assert.IsTrue(Kata.AlternatingSort(new[] { -87, -52, 83, 96, 98, 94, 68, -71 }));
        }
    }
}
