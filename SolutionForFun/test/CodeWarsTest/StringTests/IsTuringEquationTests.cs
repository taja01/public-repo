using CodeWarsTests.StringTasks;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class IsTuringEquationTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.That(Kata.IsTuringEquation("73+42=16"), Is.EqualTo(true));
            Assert.That(Kata.IsTuringEquation("5+8=13"), Is.EqualTo(false));
            Assert.That(Kata.IsTuringEquation("10+20=30"), Is.EqualTo(true));
            Assert.That(Kata.IsTuringEquation("0001000+000200=00030"), Is.EqualTo(true));
            Assert.That(Kata.IsTuringEquation("1234+5=1239"), Is.EqualTo(false));
            Assert.That(Kata.IsTuringEquation("1+0=0"), Is.EqualTo(false));
            Assert.That(Kata.IsTuringEquation("7000+8000=51"), Is.EqualTo(true));
            Assert.That(Kata.IsTuringEquation("0+0=0"), Is.EqualTo(true));
        }
    }
}
