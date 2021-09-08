using CodeWarsTests.DesignPatternsTasks.PatternCraft2;
using NUnit.Framework;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class PatternCraft2Tests
    {
        [Test]
        public void Test1()
        {
            IVisitor bullet = new TankBullet();
            ILightUnit light = new Marine();

            light.Accept(bullet);

            Assert.AreEqual(100 - 21, light.Health);
        }

        [Test]
        public void Test2()
        {
            IVisitor bullet = new TankBullet();
            IArmoredUnit armored = new Marauder();

            armored.Accept(bullet);

            Assert.AreEqual(125 - 32, armored.Health);
        }
    }
}
