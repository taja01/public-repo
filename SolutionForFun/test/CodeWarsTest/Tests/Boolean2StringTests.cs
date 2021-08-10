using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class Boolean2StringTests
    {

        [Test]
        public void MyTest()
        {
            Assert.AreEqual("True", Kata.Boolean2String(true));
            Assert.AreEqual("False", Kata.Boolean2String(false));
        }
    }
}
