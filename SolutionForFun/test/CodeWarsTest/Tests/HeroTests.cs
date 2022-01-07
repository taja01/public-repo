using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [TestCase(10, 5)]
        [TestCase(100, 40)]
        public void ATrueHero(int bullets, int dragons)
        {
            Assert.IsTrue(Kata.Hero(bullets, dragons));
        }

        [TestCase(4, 5)]
        [TestCase(1500, 751)]
        [TestCase(0, 1)]
        [TestCase(7, 4)]
        public void AFalseHero(int bullets, int dragons)
        {
            Assert.IsFalse(Kata.Hero(bullets, dragons));
        }
    }
}
