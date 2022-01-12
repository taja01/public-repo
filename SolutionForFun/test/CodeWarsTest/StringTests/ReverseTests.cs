using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class ReverseTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("World Hello", Kata.Reverse("Hello World"));
            Assert.AreEqual("There. Hi", Kata.Reverse("Hi There."));

            Assert.AreEqual("this at expert an am I", Kata.Reverse("I am an expert at this"));
        }
    }
}
