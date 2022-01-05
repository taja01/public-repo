using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class AreYouPlayingBanjoTests
    {
        [Test]
        public static void Martin()
        {
            Assert.AreEqual("Martin does not play banjo", Kata.AreYouPlayingBanjo("Martin"));
        }

        [Test]
        public static void Rikke()
        {
            Assert.AreEqual("Rikke plays banjo", Kata.AreYouPlayingBanjo("Rikke"));
        }

        [Test]
        public static void bravo()
        {
            Assert.AreEqual("bravo does not play banjo", Kata.AreYouPlayingBanjo("bravo"));
        }

        [Test]
        public static void rolf()
        {
            Assert.AreEqual("rolf plays banjo", Kata.AreYouPlayingBanjo("rolf"));
        }
    }
}
