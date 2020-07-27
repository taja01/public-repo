using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    public class RepeatStrTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("***", Kata.RepeatStr(3, "*"));
        }
    }
}
