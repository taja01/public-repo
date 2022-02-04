using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class VariableNameTests
    {
        [Test]
        public void TestMethod_False_1()
        {
            Assert.IsFalse(Kata.VariableName("qq-q"));
        }

        [Test]
        public void TestMethod_False_2()
        {
            Assert.IsFalse(Kata.VariableName("2w2"));
        }

        [Test]
        public void TestMethod_False_3()
        {
            Assert.IsFalse(Kata.VariableName(" variable"));
        }

        [Test]
        public void TestMethod_False_4()
        {
            Assert.IsFalse(Kata.VariableName("va[riable0"));
        }

        [Test]
        public void TestMethod_False_5()
        {
            Assert.IsFalse(Kata.VariableName("0ss"));
        }

        [Test]
        public void TestMethod_False_6()
        {
            Assert.IsFalse(Kata.VariableName("a a_2"));
        }

        [Test]
        public void TestMethod_True_1()
        {
            Assert.IsTrue(Kata.VariableName("var_1__Int"));
        }

        [Test]
        public void TestMethod_True_2()
        {
            Assert.IsTrue(Kata.VariableName("variable0"));
        }

        [Test]
        public void TestMethod_True_3()
        {
            Assert.IsTrue(Kata.VariableName("a"));
        }

        [Test]
        public void TestMethod_True_4()
        {
            Assert.IsTrue(Kata.VariableName("_Aas_23"));
        }
    }
}
