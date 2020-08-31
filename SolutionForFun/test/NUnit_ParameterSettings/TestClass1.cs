using NUnit.Framework;

namespace NUnit_ParameterSettings
{
    [TestFixture]
    public class TestClass1
    {
        [Category("default")]
        [Test]
        public void TestMethod()
        {
            //RUN: dotnet test NUnit_ParameterSettings.dll --filter TestCategory=default -s local.runsettings
            var device = TestContext.Parameters["Device"];
            var env = TestContext.Parameters["Environment"];

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Test", env);
                Assert.AreEqual("Desktop", device);
            });

        }

        [Category("prod")]
        [Test]
        public void TestMethod2()
        {
            //RUN: dotnet test NUnit_ParameterSettings.dll --filter TestCategory=prod -s prod.runsettings
            var device = TestContext.Parameters["Device"];
            var env = TestContext.Parameters["Environment"];
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Prod", env);
                Assert.AreEqual("Mobile", device);
            });
        }

    }
}
