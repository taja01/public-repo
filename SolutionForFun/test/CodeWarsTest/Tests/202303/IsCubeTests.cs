using CodeWarsTests.Tasks._202303;
using NUnit.Framework;

namespace CodeWarsTests.Tests._202303 {

    [TestFixture]
    internal class IsCubeTests {
        [Test]
        public void ShouldReturnFalse() {

            Assert.AreEqual(true, Practise202303.IsCube(1, 1));
            Assert.AreEqual(true, Practise202303.IsCube(8, 2));
        }
        [Test]
        public void ShouldReturnTrue() {

            Assert.AreEqual(false, Practise202303.IsCube(2, 1));
            Assert.AreEqual(false, Practise202303.IsCube(6, 3));
            Assert.AreEqual(false, Practise202303.IsCube(-8, -2));
            Assert.AreEqual(false, Practise202303.IsCube(0, 0));
            Assert.AreEqual(false, Practise202303.IsCube(200, 4));
        }
    }
}
