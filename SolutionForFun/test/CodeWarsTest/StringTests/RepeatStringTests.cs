using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class RepeatStringTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(Kata.RepeatString("*", 3), Is.EqualTo("***"));
        }

        [Test]
        public void Test2()
        {
            Assert.That(Kata.RepeatString("Hi", 2), Is.EqualTo("HiHi"));
        }

        [Test]
        public void Test3()
        {
            Assert.That(Kata.RepeatString(1234, 3), Is.EqualTo("Not a string"));
        }
    }
}
