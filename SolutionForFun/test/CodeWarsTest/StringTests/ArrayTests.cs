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
    public class ArrayTests
    {
        [Test]
        public void NullTest()
        {
            Assert.AreEqual(null, Kata.Array(""));
            Assert.AreEqual(null, Kata.Array("1"));
            Assert.AreEqual(null, Kata.Array("1, 3"));          
        }

        [Test]
        public void SampleTest()
        {          
            Assert.AreEqual("2", Kata.Array("1,2,3"));
            Assert.AreEqual("2 3", Kata.Array("1,2,3,4"));
        }
    }
}
