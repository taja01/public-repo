using CodeWarsTests.Tasks._202303;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests.Tests._202303 {

    [TestFixture]
    internal class MultipleOfIndexTests {

        [Test]
        public void BasicTest() {
            Assert.That(Practise202303.MultipleOfIndex(new List<int> { 22, -6, 32, 82, 9, 25 }), Is.EqualTo(new List<int> { -6, 32, 25 }));
            Assert.That(Practise202303.MultipleOfIndex(new List<int> { 68, -1, 1, -7, 10, 10 }), Is.EqualTo(new List<int> { -1, 10 }));
            Assert.That(Practise202303.MultipleOfIndex(new List<int> { 11, -11 }), Is.EqualTo(new List<int> { -11 }));
            Assert.That(Practise202303.MultipleOfIndex(new List<int> { -56, -85, 72, -26, -14, 76, -27, 72, 35, -21, -67, 87, 0, 21, 59, 27, -92, 68 }), Is.EqualTo(new List<int> { -85, 72, 0, 68 }));
            Assert.That(Practise202303.MultipleOfIndex(new List<int> { 28, 38, -44, -99, -13, -54, 77, -51 }), Is.EqualTo(new List<int> { 38, -44, -99 }));
            Assert.That(Practise202303.MultipleOfIndex(new List<int> { -1, -49, -1, 67, 8, -60, 39, 35 }), Is.EqualTo(new List<int> { -49, 8, -60, 35 }));
        }
    }
}
