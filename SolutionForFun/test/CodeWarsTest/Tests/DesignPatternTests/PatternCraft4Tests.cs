using CodeWarsTests.DesignPatternsTasks.PatternCraft4;
using NUnit.Framework;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class PatternCraft4Tests
    {
        [Test]
        public void TankState()
        {
            IUnit tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            Assert.AreEqual(5, tank.Damage);
        }

        [Test]
        public void SiegeState()
        {
            IUnit tank = new Tank();
            tank.State = new SiegeState();

            Assert.AreEqual(false, tank.CanMove);
            Assert.AreEqual(20, tank.Damage);
        }

        [Test]
        public void MixState()
        {
            IUnit tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            tank.State = new SiegeState();
            Assert.AreEqual(20, tank.Damage);
        }
    }
}
