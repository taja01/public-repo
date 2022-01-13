using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class RemoveDuplicateWordsTests
    {
        [Test, Description("Should handle sample case")]
        public void ExampleTest()
        {
            Assert.That(Kata.RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"), Is.EqualTo("alpha beta gamma delta"));
        }
    }
}
