using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class PlantTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("---@@@---@@@---@@@", Kata.Plant('@', 3, 3, 25));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("----$$----$$----$$----$$", Kata.Plant('$', 4, 2, 30));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("-&&&&&", Kata.Plant('&', 1, 5, 20));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("---------^", Kata.Plant('^', 3, 3, 35));
        }

        private static void Act(char seed, int water, int fert, int temp, string expected)
        {
            var msg = $"Invalid answer for input: seed='{seed}', water={water}, fert={fert}, temp={temp}";
            var actual = Kata.Plant(seed, water, fert, temp);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase('@', 4, 3, 23, "----@@@----@@@----@@@----@@@")]
        [TestCase('~', 1, 6, 30, "-~~~~~~")]
        [TestCase('#', 10, 2, 15, "----------------------------------------------------------------------------------------------------#")]
        [TestCase('*', 2, 4, 8, "----*")]
        [TestCase('<', 2, 2, 28, "--<<--<<")]
        public void SampleTests(char seed, int water, int fert, int temp, string expected)
        {
            Act(seed, water, fert, temp, expected);
        }
    }
}