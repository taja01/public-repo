using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class ChessBoardCellColorTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Kata.ChessBoardCellColor("A1", "C3"));
        }

        [Test]
        public void Test2()
        {
            Assert.IsFalse(Kata.ChessBoardCellColor("A1", "A2"));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Kata.ChessBoardCellColor("A1", "A3"));
        }

        [Test]
        public void Test4()
        {
            Assert.IsFalse(Kata.ChessBoardCellColor("A1", "H3"));
        }
    }
}
