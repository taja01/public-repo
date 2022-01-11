using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class NameShufflerTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("McClane john", Kata.NameShuffler("john McClane"));
            Assert.AreEqual("jeggins Mary", Kata.NameShuffler("Mary jeggins"));
            Assert.AreEqual("jerry tom", Kata.NameShuffler("tom jerry"));
        }
    }
}
