using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class TwiceAsOldTests
    {
        [TestCase(30, 30, 0)]
        [TestCase(16, 30, 7)]
        [TestCase(15, 45, 30)]
        public void SampleTests(int expected, int dadYears, int sonYears)
        {
            Assert.AreEqual(expected, Kata.TwiceAsOld(dadYears, sonYears));

        }
    }
}
