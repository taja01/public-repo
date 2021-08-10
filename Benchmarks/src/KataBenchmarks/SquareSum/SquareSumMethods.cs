using System;
using System.Linq;

namespace KataBenchmarks.SquareSum
{
    internal static class SquareSumMethods
    {
        public static int SquareSum(int[] n)
        {
            return n.Sum(x => x * x);
        }

        public static int SquareSumWithMath(int[] n)
        {
            return (int)n.Sum(x => Math.Pow(x, 2));
        }
    }
}
