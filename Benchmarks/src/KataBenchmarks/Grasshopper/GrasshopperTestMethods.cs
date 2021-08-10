using System.Linq;

namespace KataBenchmarks.Grasshopper
{
    internal static class GrasshopperTestMethods
    {
        public static int Summation(int num)
        {
            return num * (num + 1) / 2;
        }

        public static int SummationLinq(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
    }
}
