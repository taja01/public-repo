using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class StringToArrayTests
    {
        [Test]
        public void EExample_1()
        {
            Assert.AreEqual(new string[] { "Robin", "Singh" }, Kata.StringToArray("Robin Singh"));
        }

        [Test]
        public void EExample_2()
        {
            Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, Kata.StringToArray("I love arrays they are my favorite"));
        }
    }
}
