using CodeWarsTests.ListsKata;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class FixTheMeerkatTests
    {
        private static Random rnd = new Random();

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "head", "body", "tail" }, Kata.FixTheMeerkat(new string[] { "tail", "body", "head" }));
            Assert.AreEqual(new string[] { "heads", "body", "tails" }, Kata.FixTheMeerkat(new string[] { "tails", "body", "heads" }));
            Assert.AreEqual(new string[] { "top", "middle", "bottom" }, Kata.FixTheMeerkat(new string[] { "bottom", "middle", "top" }));
            Assert.AreEqual(new string[] { "upper legs", "torso", "lower legs" }, Kata.FixTheMeerkat(new string[] { "lower legs", "torso", "upper legs" }));
            Assert.AreEqual(new string[] { "ground", "rainbow", "sky" }, Kata.FixTheMeerkat(new string[] { "sky", "rainbow", "ground" }));
        }
    }
}
