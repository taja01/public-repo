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
            Assert.That("a".ContainsIgnoreCase("�"), Is.True);
            Assert.That("a".ContainsIgnoreCase("A"), Is.True);
            Assert.That("a".ContainsIgnoreCase("�"), Is.True);

            Assert.That("�".ContainsIgnoreCase("a"), Is.True);
            Assert.That("�".ContainsIgnoreCase("�"), Is.True);
            Assert.That("�".ContainsIgnoreCase("A"), Is.True);
            Assert.That("�".ContainsIgnoreCase("�"), Is.True);

            Assert.That("�lom".ContainsIgnoreCase("alom"), Is.True);
            Assert.That("alom".ContainsIgnoreCase("�lom"), Is.True);

            Assert.That("SAVAGE".ContainsIgnoreCase("savage"), Is.True);
            Assert.That("savage".ContainsIgnoreCase("SAVAGE"), Is.True);
        }
    }
}