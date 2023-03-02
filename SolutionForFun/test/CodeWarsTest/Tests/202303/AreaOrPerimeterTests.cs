using CodeWarsTests.Tasks._202303;
using NUnit.Framework;

namespace CodeWarsTests.Tests._202303 {

    [TestFixture]
    internal class AreaOrPerimeterTests {
        [Test]
        public void FixedTest() {
            Assert.AreEqual(Practise202303.AreaOrPerimeter(4, 4), 16);
            Assert.AreEqual(Practise202303.AreaOrPerimeter(6, 10), 32);
        }
    }
}
