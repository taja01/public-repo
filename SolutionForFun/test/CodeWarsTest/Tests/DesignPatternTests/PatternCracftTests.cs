using CodeWarsTests.DesignPatternsTasks.PatternCracft;
using NUnit.Framework;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class PatternCracftTests
    {
        public void Test()
        {
            var marioAdapter = new MarioAdapter(new Mario());
            var target = new Target { Health = 33 };

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }

    }
}
