using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class SayHelloTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", Kata.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
        }
    }
}
