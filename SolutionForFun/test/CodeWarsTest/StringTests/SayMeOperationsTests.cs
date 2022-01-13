using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class SayMeOperationsTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("addition", Kata.SayMeOperations("2 2 4"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("division, subtraction, multiplication, subtraction", Kata.SayMeOperations("10 2 5 -3 -15 12"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("subtraction, multiplication, addition", Kata.SayMeOperations("9 4 5 20 25"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("addition, addition, addition", Kata.SayMeOperations("1 2 3 5 8"));
        }
    }
}
