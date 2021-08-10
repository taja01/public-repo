using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.Tasks
{
    public partial class Kata
    {

        /*
         * You're given three integers, a, b and c.
         * It is guaranteed that two of these integers are equal to each other.
         * What is the value of the third integer?
         */
        public static int ExtraNumber(int a, int b, int c)
        {
            return a ^ b ^ c;

            //return a == b
            //    ? c
            //    : a == c ? b : a;
        }

        /*
         * Given integers a and b, determine whether the following pseudocode results in an infinite loop
         * while a is not equal to b do
         * increase a by 1
         *  decrease b by 1
         * Assume that the program is executed on a virtual machine which can store arbitrary long numbers and execute forever.
         */
        public static bool IsInfiniteProcess(int a, int b)
        {
            return (a > b || (a + b) % 2 != 0);
        }


        /*
         * Consider an arithmetic expression of the form a#b=c. 
         * Check whether it is possible to replace # with one of the four signs: +, -, * or / to obtain a correct expression.
         */
        public static bool ArithmeticExpression(int a, int b, int c)
        {
            return a + b == c || a - b == c || a * b == c || b * c == a;
        }

        /// <summary>
        /// Interview task, return second int.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SecondMaxInteger(int[] array)
        {
            if (array == null)
            {
                throw new System.Exception("Array cannot be null");
            }

            if (array.Length < 2)
            {
                throw new System.Exception("Array length should be more than 1");
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
            }
            return secondMax;
        }

        //The main idea is to count all the occurring characters in a string.
        //If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
        //What if the string is empty? Then the result should be empty object literal, {}.
        public static Dictionary<char, int> Count(string str)
        {
            return str.ToCharArray().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }

        //Given an array of integers, find the one that appears an odd number of times.
        //There will always be only one integer that appears an odd number of times.
        public static int FindIt(int[] seq)
        {
            return seq
                .GroupBy(x => x)
                .Where(i => i.Count() % 2 == 1)
                .Single().Key;
        }

        //In this kata you have to create all permutations of an input string and remove duplicates, if present.
        //This means, you have to shuffle all letters from the input in all possible orders.
        public static List<string> SinglePermutations(string s)
        {
            if (s.Length < 2)
            {
                return new List<string> { s };
            }

            var result = new HashSet<string>();
            foreach (var sub in SinglePermutations(s.Substring(1)))
            {
                for (int i = 0; i <= sub.Length; i++)
                {
                    var r = sub.Substring(0, i) + s[0] + sub.Substring(i);
                    result.Add(r);
                }
            }
            return result.ToList();
        }
    }
}
