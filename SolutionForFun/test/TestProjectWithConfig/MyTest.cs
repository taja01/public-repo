using NUnit.Framework;

namespace TestProjectWithConfig
{
    [TestFixture]
    public class MyTest : TestSetupBase
    {
        [Test]
        public void TestMethod()
        {
            Assert.NotNull(Configuration);
            Assert.AreNotEqual("none", Configuration["WhereIam"]);
            Assert.AreEqual(EnvironmentName, Configuration["WhereIam"]);
        }
    }
}
