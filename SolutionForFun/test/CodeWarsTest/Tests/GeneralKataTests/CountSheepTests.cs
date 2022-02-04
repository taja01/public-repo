using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class CountSheepTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.That(Kata.CountSheep(0), Is.EqualTo(""));
            Assert.That(Kata.CountSheep(1), Is.EqualTo("1 sheep..."));
            Assert.That(Kata.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
            Assert.That(Kata.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
        }
    }
}
