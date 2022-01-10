﻿using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class AbbrevNameTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("S.H", Kata.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", Kata.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", Kata.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", Kata.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", Kata.AbbrevName("david mendieta"));
        }
    }
}
