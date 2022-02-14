using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class FinalGradeTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(100, Kata.FinalGrade(100, 12));
            Assert.AreEqual(90, Kata.FinalGrade(85, 5));
        }
    }
}
