using BenchmarkDotNet.Attributes;

namespace KataBenchmarks.RemoveVowel
{
    public class BenchmarkRemoveVowel
    {
        [Benchmark]
        public bool TestDisemvowelRegex1() => "Ths wbst s fr lsrs LL!".Equals(RemoveVowelTestMethods.DisemvowelRegex1(RemoveVowelTestData.TestText));

        [Benchmark]
        public bool TestDisemvowelRegex2() => "Ths wbst s fr lsrs LL!".Equals(RemoveVowelTestMethods.DisemvowelRegex2(RemoveVowelTestData.TestText));

        [Benchmark]
        public bool TestDisemvowelLinQ1() => "Ths wbst s fr lsrs LL!".Equals(RemoveVowelTestMethods.DisemvowelLinQ1(RemoveVowelTestData.TestText));

        [Benchmark]
        public bool TestDisemvowelLinQ2() => "Ths wbst s fr lsrs LL!".Equals(RemoveVowelTestMethods.DisemvowelLinQ2(RemoveVowelTestData.TestText));
    }
}
