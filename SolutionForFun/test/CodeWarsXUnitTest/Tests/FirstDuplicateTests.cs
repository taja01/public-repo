using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class FirstDuplicateTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(3, Kata.FirstDuplicate(new[] { 2, 1, 3, 5, 3, 2 }));
            Assert.AreEqual(2, Kata.FirstDuplicate(new[] { 2, 2 }));
            Assert.AreEqual(-1, Kata.FirstDuplicate(new[] { 2, 4, 3, 5, 1 }));
        }
    }
}