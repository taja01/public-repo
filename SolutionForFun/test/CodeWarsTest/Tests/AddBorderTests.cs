using CodeWarsTests.Tasks;
using NUnit.Framework;

namespace CodeWarsTests.Tests
{
    [TestFixture]
    public class AddBorderTests
    {
        [Test]
        public void Test1()
        {
            var picture = new[]
            {
                "a",
            };

            var expected_array = new[]
            {
                "***",
                "*a*",
                "***"
            };

            CollectionAssert.AreEqual(expected_array, Kata.AddBorder(picture));
        }

        [Test]
        public void Test2()
        {
            var picture = new[]
            {
                "abc",
                "ded"
            };

            var expected_array = new[]
            {
                "*****",
                "*abc*",
                "*ded*",
                "*****"
            };

            CollectionAssert.AreEqual(expected_array, Kata.AddBorder(picture));
        }
    }
}
