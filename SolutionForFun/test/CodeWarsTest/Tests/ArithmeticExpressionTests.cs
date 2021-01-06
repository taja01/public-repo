using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class ArithmeticExpressionTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Kata.ArithmeticExpression(2, 3, 5));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Kata.ArithmeticExpression(8, 2, 4));
        }

        [Test]
        public void Test3()
        {
            Assert.IsFalse(Kata.ArithmeticExpression(8, 3, 2));
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Kata.ArithmeticExpression(6, 3, 3));
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Kata.ArithmeticExpression(18, 2, 9));
        }
    }
}
