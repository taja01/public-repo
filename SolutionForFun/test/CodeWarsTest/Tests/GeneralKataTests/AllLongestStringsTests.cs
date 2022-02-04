using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class AllLongestStringsTests
    {
        [Test]
        public void Test()
        {
            CollectionAssert.AreEqual(new[] { "aba", "vcd", "aba" },
                Kata.AllLongestStrings(new[] { "aba", "aa", "ad", "vcd", "aba" }));
        }
    }
}