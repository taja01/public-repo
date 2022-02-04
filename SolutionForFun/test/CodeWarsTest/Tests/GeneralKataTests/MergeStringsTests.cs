using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class MergeStringsTests
    {
        [Test]
        public void TestMethod0()
        {
            Assert.AreEqual("gfeoerkgseeks", Kata.MergeStrings("geeks", "forgeeks"));
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual("dcccecbd", Kata.MergeStrings("dce", "cccbd"));
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual("stuopweerr", Kata.MergeStrings("super", "tower"));
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual("az", Kata.MergeStrings("a", "z"));
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual("ugcrhlmfelno", Kata.MergeStrings("uchlmfelno", "gr"));
        }
    }
}
