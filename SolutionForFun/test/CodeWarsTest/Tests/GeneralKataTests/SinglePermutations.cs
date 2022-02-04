using CodeWarsTests.Tasks;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class SinglePermutations
    {
        [Test]
        public void Example1()
        {
            Assert.AreEqual(new List<string> { "a" }, Kata.SinglePermutations("a").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example2()
        {
            Assert.AreEqual(new List<string> { "ab", "ba" }, Kata.SinglePermutations("ab").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example3()
        {
            Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, Kata.SinglePermutations("aabb").OrderBy(x => x).ToList());
        }
    }
}
