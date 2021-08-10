using BenchmarkDotNet.Attributes;

namespace KataBenchmarks.SquareSum
{
    public class BenchmarkSquareSum
    {
        [Benchmark]
        public bool TestShortSquareSum() => 14.Equals(SquareSumMethods.SquareSum(new[] { 1, 2, 3 }));

        [Benchmark]
        public bool TestShortSquareSumWithMath() => 14.Equals(SquareSumMethods.SquareSumWithMath(new[] { 1, 2, 3 }));

        [Benchmark]
        public bool TestMediumSquareSum() => 140000.Equals(SquareSumMethods.SquareSum(new[] { 100, 200, 300 }));

        [Benchmark]
        public bool TestMediumSquareSumWithMath() => 140000.Equals(SquareSumMethods.SquareSumWithMath(new[] { 100, 200, 300 }));

        [Benchmark]
        public bool TestBigSquareSum() => 91140000.Equals(SquareSumMethods.SquareSum(new[] { 100, 200, 300, 1000, 2000, 3000, 4000, 5000, 6000 }));

        [Benchmark]
        public bool TestBigSquareSumWithMath() => 91140000.Equals(SquareSumMethods.SquareSumWithMath(new[] { 100, 200, 300, 1000, 2000, 3000, 4000, 5000, 6000 }));
    }
}
