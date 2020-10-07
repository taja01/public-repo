using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class AlternatingSumsTests
    {
        [Test]
        public void Test1()
        {
            CollectionAssert.AreEqual(new int[] { 180, 105 }, Kata.AlternatingSums(new int[] { 50, 60, 60, 45, 70 }));
        }

        [Test]
        public void Test2()
        {
            CollectionAssert.AreEqual(new int[] { 100, 50 }, Kata.AlternatingSums(new int[] { 100, 50 }));
        }

        [Test]
        public void Test3()
        {
            CollectionAssert.AreEqual(new int[] { 80, 0 }, Kata.AlternatingSums(new int[] { 80 }));
        }

        [Test]
        public void Test4()
        {
            CollectionAssert.AreEqual(new int[] { 150, 150 }, Kata.AlternatingSums(new int[] { 100, 50, 50, 100 }));
        }
    }
}
