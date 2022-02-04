using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class AlphabeticShiftTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("a", Kata.AlphabeticShift("z"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("dsbaz", Kata.AlphabeticShift("crazy"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("bbbbcccdde", Kata.AlphabeticShift("aaaabbbccd"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("gvaaz", Kata.AlphabeticShift("fuzzy"));
        }
    }
}
