using CodeWarsTests.DesignPatternsTasks.PatternCraft5;
using NUnit.Framework;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class PatternCraft5Tests
    {
        [Test]
        public void SingleUpgrade()
        {
            IMarine marine = new Marine(10, 1);

            Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
            Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
        }

        [Test]
        public void DoubleUpgrade()
        {
            IMarine marine = new Marine(15, 1);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            Assert.AreEqual(17, marine.Damage);
        }

        [Test]
        public void TripleUpgrade()
        {
            IMarine marine = new Marine(20, 1);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            Assert.AreEqual(23, marine.Damage);
        }
    }
}
