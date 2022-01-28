using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.ListsKata
{
    partial class Kata
    {
        //https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
        //In this kata you will create a function that takes a list of non-negative integers and strings and
        //returns a new list with the strings filtered out.
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //return listOfItems
            //    .Where(x => x.GetType() == Type.GetType("System.Int32"))
            //    .Select(y => int.Parse(y.ToString()));

            return listOfItems.OfType<int>();
        }

        /*
         * https://www.codewars.com/kata/55fd2d567d94ac3bc9000064
         * Given the triangle of consecutive odd numbers:
         *            1
         *        3     5
         *      7     9    11
         *      Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)
         *      1 -->  1
         *      2 --> 3 + 5 = 8
        */
        public static long RowSumOddNumbers(long n)
        {
            return n * n * n;
        }
    }
}
