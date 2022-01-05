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
    public class StringyTests
    {
        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "10")]
        [TestCase(10, ExpectedResult = "1010101010")]
        public static string FixedTest(int size)
        {
            return Kata.Stringy(size);
        }
    }
}
