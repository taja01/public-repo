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

        /*
         * https://www.codewars.com/kata/563cf89eb4747c5fb100001b
         * Given an array of integers, remove the smallest value.
         * Do not mutate the original array/list. 
         * If there are multiple elements with the same value, remove the one with a lower index. 
         * If you get an empty array/list, return an empty array/list.
         * Don't change the order of the elements that are left.
         */
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            //if (numbers == null || numbers.Count == 0)
            //{
            //    return new List<int>();
            //}

            //var m = numbers.Min();
            //var index = numbers.IndexOf(m);
            //numbers.RemoveAt(index);

            //return numbers;

            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }

        /*
         * https://www.codewars.com/kata/559590633066759614000063
         * Write a function that returns both the minimum and maximum number of the given list/array.
         */
        public static int[] MinMax(int[] lst)
        {
            return new[] { lst.Min(), lst.Max() };
        }

    }
}
