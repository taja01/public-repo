using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class GreetTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }
}
