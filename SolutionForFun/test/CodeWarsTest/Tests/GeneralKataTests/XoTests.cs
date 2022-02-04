using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    public class XoTests
    {
        [Test]
        public void Test1()
        {
            Assert.True(Kata.XO("xo"));
            Assert.True(Kata.XO("xxOo"));
            Assert.False(Kata.XO("xxxm"));
            Assert.False(Kata.XO("Oo"));
            Assert.False(Kata.XO("ooom"));
        }

    }
}