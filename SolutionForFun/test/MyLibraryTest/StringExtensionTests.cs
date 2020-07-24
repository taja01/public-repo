using MyLibrary;
using NUnit.Framework;

namespace MyLibraryTest
{
    [TestFixture]
    public class IgnoreAccentTest
    {
        [Test]
        public void Test()
        {
            Assert.That("a".ContainsIgnoreCase("a"), Is.True);
            Assert.That("a".ContainsIgnoreCase("á"), Is.True);
            Assert.That("a".ContainsIgnoreCase("A"), Is.True);
            Assert.That("a".ContainsIgnoreCase("Á"), Is.True);

            Assert.That("á".ContainsIgnoreCase("a"), Is.True);
            Assert.That("á".ContainsIgnoreCase("á"), Is.True);
            Assert.That("á".ContainsIgnoreCase("A"), Is.True);
            Assert.That("á".ContainsIgnoreCase("Á"), Is.True);

            Assert.That("álom".ContainsIgnoreCase("alom"), Is.True);
            Assert.That("alom".ContainsIgnoreCase("álom"), Is.True);

            Assert.That("SAVAGE".ContainsIgnoreCase("savage"), Is.True);
            Assert.That("savage".ContainsIgnoreCase("SAVAGE"), Is.True);
        }
    }
}