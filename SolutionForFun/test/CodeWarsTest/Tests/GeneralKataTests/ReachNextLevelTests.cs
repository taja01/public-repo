using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ReachNextLevelTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Kata.ReachNextLevel(10, 15, 5));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Kata.ReachNextLevel(3, 6, 4));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Kata.ReachNextLevel(97, 57, 7));

        }

        [Test]
        public void Test4()
        {
            Assert.IsFalse(Kata.ReachNextLevel(10, 15, 4));
        }

        [Test]
        public void Test5()
        {
            Assert.IsFalse(Kata.ReachNextLevel(84, 135, 36));
        }

        [Test]
        public void Test6()
        {
            Assert.IsFalse(Kata.ReachNextLevel(74, 170, 58));
        }

        [Test]
        public void Test7()
        {
            Assert.IsFalse(Kata.ReachNextLevel(80, 199, 15));
        }
    }
}
