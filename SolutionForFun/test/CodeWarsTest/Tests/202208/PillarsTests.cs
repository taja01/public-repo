﻿using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests._202208
{
    [TestFixture]
    public class PillarsTests
    {
        [Test]
        public void BasicTest1()
        {
            Assert.AreEqual(0, Kata.Pillars(1, 10, 10), "Testing for number of pillars: 1, distance: 10 m and width: 10 cm");
        }

        [Test]
        public void BasicTest2()
        {
            Assert.AreEqual(2000, Kata.Pillars(2, 20, 25), "Testing for number of pillars: 2, distance: 20 m and width: 25 cm");
        }

        [Test]
        public void BasicTest3()
        {
            Assert.AreEqual(15270, Kata.Pillars(11, 15, 30), "Testing for number of pillars: 11, distance: 15 m and width: 30 cm");
        }
    }
}