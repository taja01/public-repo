using CodeWarsXUnitTest.Tasks;
using Xunit;

namespace CodeWarsXUnitTest.Tests
{
    public class DisemvowelTests
    {
        [Fact]
        public void ShouldRemoveAllVowels()
        {
            Assert.Equal("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }
    }
}
