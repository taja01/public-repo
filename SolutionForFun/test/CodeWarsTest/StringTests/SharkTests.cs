using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class SharkTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Alive!", Kata.Shark(28, 141, 2, 10, false));
                Assert.AreEqual("Alive!", Kata.Shark(15, 169, 1, 11, false));
            });

        }

        [Test]
        public void BasicTest()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Alive!", Kata.Shark(12, 50, 4, 8, true));
                Assert.AreEqual("Alive!", Kata.Shark(12, 50, 4, 8, false));
                Assert.AreEqual("Alive!", Kata.Shark(7, 55, 4, 16, true));
                Assert.AreEqual("Shark Bait!", Kata.Shark(24, 0, 4, 8, true));
                Assert.AreEqual("Shark Bait!", Kata.Shark(40, 35, 3, 20, true));
                Assert.AreEqual("Alive!", Kata.Shark(7, 8, 3, 4, true));
                Assert.AreEqual("Shark Bait!", Kata.Shark(7, 8, 3, 4, false));
            });
        }
    }
}
