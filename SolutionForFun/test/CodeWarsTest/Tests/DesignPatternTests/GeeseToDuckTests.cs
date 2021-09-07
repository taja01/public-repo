using CodeWarsTests.DesignPatternsTasks.GeeseToDuck;
using NUnit.Framework;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class GeeseToDuckTests
    {
        [Test]
        public void TestMethod()
        {
            Goose goose = new Goose();
            GooseToIDuckAdapter adapter = new GooseToIDuckAdapter(goose);

            Assert.AreEqual(adapter.Quack(), goose.Honk());
        }
    }
}
