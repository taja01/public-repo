using CodeWarsXUnitTest.Tasks;
using Xunit;

namespace CodeWarsXUnitTest.Tests
{
    public class XoTests
    {
        [Fact]
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