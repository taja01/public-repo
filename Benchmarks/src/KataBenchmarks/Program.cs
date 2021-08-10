using BenchmarkDotNet.Running;
using KataBenchmarks.SquareSum;

namespace KataBenchmarks
{
    internal class Program
    {
        private static void Main()
        {
            //BenchmarkRunner.Run<BenchmarkRemoveVowel>();
            //BenchmarkRunner.Run<BenchmarkGrasshopperSum>();
            BenchmarkRunner.Run<BenchmarkSquareSum>();
        }
    }
}
