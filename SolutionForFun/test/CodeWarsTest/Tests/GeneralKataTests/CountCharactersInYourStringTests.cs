using CodeWarsTests.Tasks;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class CountCharactersInYourStringTests
    {
        [Test]
        public static void FixedTest_aaaa()
        {
            var d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, Kata.Count("aaaa"));
        }

        [Test]
        public static void FixedTest_aabb()
        {
            var d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(d, Kata.Count("aabb"));
        }

        public static void NullTest()
        {
            Assert.Null(Kata.Count(null));
        }

        public static void EmptyTest()
        {
            Assert.Null(Kata.Count(string.Empty));
        }
    }
}
