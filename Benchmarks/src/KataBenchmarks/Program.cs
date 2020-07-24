using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataBenchmarks
{
    internal class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Bench>();
        }
    }

    internal class TestData
    {
        public const string TestText = "This website is for losers LOL!";
    }

    internal static class TestMethods
    {
        public static string DisemvowelRegex1(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string DisemvowelRegex2(string str)
        {
            return Regex.Replace(str, "[euioa]", "", RegexOptions.IgnoreCase); ;
        }
        public static string DisemvowelLinQ1(string str)
        {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }
        public static string DisemvowelLinQ2(string str)
        {
            return new string(str.Where(c => !"aeiuoAEIOU".Contains(c)).ToArray());
        }
    }

    public class Bench
    {
        [Benchmark]
        public bool TestDisemvowelRegex1() => "Ths wbst s fr lsrs LL!".Equals(TestMethods.DisemvowelRegex1(TestData.TestText));

        [Benchmark]
        public bool TestDisemvowelRegex2() => "Ths wbst s fr lsrs LL!".Equals(TestMethods.DisemvowelRegex2(TestData.TestText));

        [Benchmark]
        public bool TestDisemvowelLinQ1() => "Ths wbst s fr lsrs LL!".Equals(TestMethods.DisemvowelLinQ1(TestData.TestText));

        [Benchmark]
        public bool TestDisemvowelLinQ2() => "Ths wbst s fr lsrs LL!".Equals(TestMethods.DisemvowelLinQ2(TestData.TestText));
    }
}
