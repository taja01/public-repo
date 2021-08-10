using BenchmarkDotNet.Attributes;

namespace KataBenchmarks.Grasshopper
{
    public class BenchmarkGrasshopperSum
    {
        [Benchmark]
        public bool TestShortSimpleSummation() => 3.Equals(GrasshopperTestMethods.Summation(2));

        [Benchmark]
        public bool TestShortSummationLinq() => 3.Equals(GrasshopperTestMethods.SummationLinq(2));

        [Benchmark]
        public bool TestBigSummation() => 50005000.Equals(GrasshopperTestMethods.Summation(10000));

        [Benchmark]
        public bool TestBigSummationLinq() => 50005000.Equals(GrasshopperTestMethods.SummationLinq(10000));
    }
}
