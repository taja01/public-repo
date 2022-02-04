using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class MoveZeroesTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(new[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}