using CodeWarsTests.Tasks;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests.Tests.GeneralKataTests
{
    [TestFixture]
    public class AlphanumericTests
    {
        private static IEnumerable<TestCaseData> cases
        {
            get
            {
                yield return new TestCaseData("Mazinkaiser").Returns(true);
                yield return new TestCaseData("hello world_").Returns(false);
                yield return new TestCaseData("PassW0rd").Returns(true);
                yield return new TestCaseData("     ").Returns(false);
                yield return new TestCaseData("").Returns(false);
            }
        }

        [Test, TestCaseSource("cases")]
        public bool Test(string str) => Kata.Alphanumeric(str);
    }
}
