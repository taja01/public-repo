using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class WellTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("Fail!", Kata.Well(new string[] { "bad", "bad", "bad" }));
            Assert.AreEqual("Publish!", Kata.Well(new string[] { "good", "bad", "bad", "bad", "bad" }));
            Assert.AreEqual("I smell a series!", Kata.Well(new string[] { "good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good" }));
        }
    }
}
