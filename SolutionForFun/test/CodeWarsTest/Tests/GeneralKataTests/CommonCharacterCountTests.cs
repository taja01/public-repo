using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class CommonCharacterCountTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(0, Kata.CommonCharacterCount("a", "b"));
            Assert.AreEqual(3, Kata.CommonCharacterCount("aabcc", "adcaa"));
            Assert.AreEqual(4, Kata.CommonCharacterCount("zzzz", "zzzzzzz"));
            Assert.AreEqual(3, Kata.CommonCharacterCount("abca", "xyzbac"));
        }
    }
}