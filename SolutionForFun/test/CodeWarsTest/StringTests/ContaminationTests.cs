using CodeWarsTests.StringTasks;
using NUnit.Framework;
using System;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class ContaminationTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("zzz", Kata.Contamination("abc", "z"));
            Assert.AreEqual("", Kata.Contamination("", "z"));
            Assert.AreEqual("", Kata.Contamination("abc", String.Empty));
            Assert.AreEqual("&&&&&&&&", Kata.Contamination("_3ebzgh4", "&"));
            Assert.AreEqual("      ", Kata.Contamination("//case", " "));
        }
    }
}
