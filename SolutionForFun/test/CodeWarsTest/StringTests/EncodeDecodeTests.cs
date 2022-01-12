using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class EncodeDecodeTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.Encode("Hello World!"), Is.EqualTo("ưɞʈʈʚÀȊʚʬʈɘÆ"));
            Assert.That(Kata.Decode("ưɞʈʈʚÀȊʚʬʈɘÆ"), Is.EqualTo("Hello World!"));
        }
    }
}
