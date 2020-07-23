using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Running;

namespace ParsingIntBenchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<Bench>();
        }
    }

    internal class TestData
    {
        public IList<string> StringAndNumbers = new List<string> { "0", "b", ",", "", "qweasd" };
    }

    public class Bench
    {
        private readonly TestData testData = new TestData();

        [Benchmark]
        public bool TestIntParse()
        {
            var counter = 0;
            foreach (var str in testData.StringAndNumbers)
            {
                try
                {
                    var i = int.Parse(str);
                    counter++;
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return counter == 1;
        }

        [Benchmark]
        public bool TestRegex()
        {
            var counter = 0;
            const string PATTERN = @"\d+";
            foreach (var str in testData.StringAndNumbers)
            {
                if (Regex.IsMatch(str, PATTERN))
                {
                    counter++;
                }
            }

            return counter == 1;
        }


        [Benchmark]
        public bool TestIntTryParse()
        {
            var counter = testData.StringAndNumbers.Count(str => int.TryParse(str, out _));

            return counter == 1;
        }

    }
}
