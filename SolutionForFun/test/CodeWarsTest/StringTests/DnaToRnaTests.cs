using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class DnaToRnaTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("UUUU", Kata.DnaToRna("TTTT"));
            Assert.AreEqual("GCAU", Kata.DnaToRna("GCAT"));
        }
    }
}
