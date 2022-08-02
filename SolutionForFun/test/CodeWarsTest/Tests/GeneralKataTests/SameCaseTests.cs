using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class SameCaseTests
    {
        [Test]
        public void TrueTests()
        {
            Assert.AreEqual(1, Kata.SameCase('a', 'u'));
            Assert.AreEqual(1, Kata.SameCase('A', 'U'));
            Assert.AreEqual(1, Kata.SameCase('Q', 'P'));
            Assert.AreEqual(1, Kata.SameCase('w', 'y'));
            Assert.AreEqual(1, Kata.SameCase('c', 'm'));
            Assert.AreEqual(1, Kata.SameCase('N', 'W'));
        }
        [Test]
        public void FalseTests()
        {
            Assert.AreEqual(0, Kata.SameCase('a', 'U'));
            Assert.AreEqual(0, Kata.SameCase('A', 'u'));
            Assert.AreEqual(0, Kata.SameCase('Q', 'p'));
            Assert.AreEqual(0, Kata.SameCase('w', 'Y'));
            Assert.AreEqual(0, Kata.SameCase('c', 'M'));
            Assert.AreEqual(0, Kata.SameCase('N', 'w'));
        }
        [Test]
        public void NotLetters()
        {
            Assert.AreEqual(-1, Kata.SameCase('a', '*'));
            Assert.AreEqual(-1, Kata.SameCase('A', '%'));
            Assert.AreEqual(-1, Kata.SameCase('Q', '1'));
            Assert.AreEqual(-1, Kata.SameCase('w', '-'));
            Assert.AreEqual(-1, Kata.SameCase('c', '8'));
            Assert.AreEqual(-1, Kata.SameCase('N', ':'));
        }
    }
}