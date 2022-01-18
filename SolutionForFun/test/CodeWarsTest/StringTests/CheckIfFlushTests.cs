using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class CheckIfFlushTests
    {
        [TestCase(true, new string[] { "AS", "3S", "9S", "KS", "4S" })]
        [TestCase(false, new string[] { "AD", "4S", "7H", "KC", "5S" })]
        [TestCase(false, new string[] { "10D", "4S", "7H", "KC", "5S" })]
        [TestCase(true, new string[] { "10D", "QD", "7D", "KD", "5D" })]
        public void TestMethod(bool result, string[] cards)
        {
            Assert.AreEqual(result, Kata.CheckIfFlush(cards));
        }
    }
}
