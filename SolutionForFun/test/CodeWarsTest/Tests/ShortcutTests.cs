using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class ShortcutTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(Kata.Shortcut("hello"), "hll");
            Assert.AreEqual(Kata.Shortcut("how are you today?"), "hw r y tdy?");
            Assert.AreEqual(Kata.Shortcut("complain"), "cmpln");
            Assert.AreEqual(Kata.Shortcut("never"), "nvr");
        }
    }
}
