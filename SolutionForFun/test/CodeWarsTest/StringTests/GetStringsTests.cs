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
    public class GetStringsTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", Kata.GetStrings("Chicago"));
            Assert.AreEqual("b:*,a:*,n:*,g:*,k:**,o:*", Kata.GetStrings("Bangkok"));
            Assert.AreEqual("l:*,a:**,s:**,v:*,e:*,g:*", Kata.GetStrings("Las Vegas"));
        }
    }
}
