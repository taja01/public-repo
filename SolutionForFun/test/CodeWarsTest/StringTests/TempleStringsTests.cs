using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class TempleStringsTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("Animals are Good", Kata.TempleStrings("Animals", "Good"));
        }
    }
}
