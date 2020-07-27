using CodeWarsXUnitTest.Tasks;
using Xunit;

namespace CodeWarsXUnitTest.Tests
{
    public class RepeatStrTests
    {
        [Fact]
        public void MyTest()
        {
            Assert.Equal("***", Kata.RepeatStr(3, "*"));
        }
    }
}
