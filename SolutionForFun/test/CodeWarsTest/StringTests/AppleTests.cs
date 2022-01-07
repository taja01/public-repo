using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class AppleTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("It's hotter than the sun!!", Kata.Apple("50"));
            Assert.AreEqual("Help yourself to a honeycomb Yorkie for the glovebox.", Kata.Apple(4));
        }
    }
}
