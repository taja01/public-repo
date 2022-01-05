using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class LowercaseCountCheckTests
    {
        [Test]
        [TestCase("abc", ExpectedResult = 3)]
        [TestCase("abcABC123", ExpectedResult = 3)]
        [TestCase("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 3)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 0)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", ExpectedResult = 26)]
        [TestCase("nXspvG§§ccVRjn)ANgh!f707H)KtjfVaiq=CZTi$b2V2mx", ExpectedResult = 21)]
        [TestCase("Jg/G§%Ar§2byMD)pINob)QRI=$xDr%o%a4(%NXDK1nm4hX7afgN", ExpectedResult = 17)]
        public static int FixedTest(string str)
        {
            return Kata.LowercaseCountCheck(str);
        }
    }
}
