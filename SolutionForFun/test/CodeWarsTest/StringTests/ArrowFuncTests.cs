using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class ArrowFuncTests
    {
        [Test]
        public void BaseTest()
        {
            Assert.AreEqual("a", Kata.ArrowFunc(new int[] { 97 }), "");
        }
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("Test", Kata.ArrowFunc(new int[] { 84, 101, 115, 116 }), "");
        }
    }
}
