using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class KknapsackLightTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(10, Kata.KknapsackLight(10, 5, 6, 4, 8));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(16, Kata.KknapsackLight(10,5,6,4,9));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(7, Kata.KknapsackLight(5,3,7,4,6));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(0, Kata.KknapsackLight(10,2,11,3,1));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(15, Kata.KknapsackLight(15,2,20,3,2));
        }
    }
}
