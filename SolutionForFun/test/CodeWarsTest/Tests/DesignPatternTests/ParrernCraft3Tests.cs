using CodeWarsTests.DesignPatternsTasks.PatternCraft3;
using NUnit.Framework;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class ParrernCraft3Tests
    {
        [Test]
        public void WalkTest()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);
            viking.Move();
            Assert.AreEqual(2, viking.Position);
        }

        [Test]
        public void FlyTest()
        {
            IUnit viking = new Viking();
            viking.MoveBehavior = new Fly();

            viking.Move();
            Assert.AreEqual(10, viking.Position);
            viking.Move();
            Assert.AreEqual(20, viking.Position);
        }

        [Test]
        public void MixedMoveTest()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);

            viking.MoveBehavior = new Fly();
            viking.Move();
            Assert.AreEqual(11, viking.Position);
        }
    }
}
