using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
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
