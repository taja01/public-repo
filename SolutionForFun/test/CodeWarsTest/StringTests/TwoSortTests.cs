using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class TwoSortTests
    {
        [Test]
        public void BasicTests1()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", Kata.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
        }

        [Test]
        public void BasicTests2()
        {
            Assert.AreEqual("a***r***e", Kata.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
        }

        [Test]
        public void BasicTests3()
        {
            Assert.AreEqual("D***a***r***k***C***o***i***n", Kata.TwoSort(new[] { "ProofOfStake", "Dash", "ProofOfStake", "LiteCoin", "MadeSafeCoin", "Waves", "Waves", "Ethereum", "Lisk", "ProofOfStake", "DarkCoin", "Waves" }));
        }
    }
}
