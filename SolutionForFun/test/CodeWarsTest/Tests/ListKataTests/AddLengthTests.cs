using CodeWarsTests.ListsKata;
using NUnit.Framework;

namespace CodeWarsTests.Tests.ListKataTests
{
    [TestFixture]
    public class AddLengthTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "apple 5", "ban 3" }, Kata.AddLength("apple ban"));
            Assert.AreEqual(new string[] { "you 3", "will 4", "win 3" }, Kata.AddLength("you will win"));
        }
    }
}
