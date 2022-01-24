using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class DoublesTestsű
    {
        [Test]
        public void TestMethod()
        {
            Assert.That(Kata.Doubles("abbbzz"), Is.EqualTo("ab"));
            Assert.That(Kata.Doubles("zzzzykkkd"), Is.EqualTo("ykd"));
            Assert.That(Kata.Doubles("abbcccdddda"), Is.EqualTo("aca"));
            Assert.That(Kata.Doubles("vvvvvoiiiiin"), Is.EqualTo("voin"));
            Assert.That(Kata.Doubles("rrrmooomqqqqj"), Is.EqualTo("rmomj"));
            Assert.That(Kata.Doubles("xxbnnnnnyaaaaam"), Is.EqualTo("bnyam"));
        }
    }
}
