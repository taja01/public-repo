using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class Multiples3_5Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Multiples3_5(10));
        }
    }
}