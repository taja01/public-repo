using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericListBenchmark
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
        public List<Guid> GetGuids { get; } = new List<Guid>(Enumerable.Range(0, 10000).Select(g => Guid.NewGuid()));

        public IEnumerable<Guid> GetIeNumerables()
        {
            foreach (var item in GetGuids)
            {
                yield return item;
            }
        }
    }

    public class Bench
    {
        private readonly TestData testData = new TestData();

        [Benchmark]
        public bool Test_Any_Method() => testData.GetGuids.Any();

        [Benchmark]
        public bool Test_Count_Property() => testData.GetGuids.Count > 0;


        [Benchmark]
        public bool Test_Generic_Any_Method() => testData.GetIeNumerables().Any();

        [Benchmark]
        public bool Test_Generic_Count_Method() => testData.GetIeNumerables().Count() > 0;
    }
}
