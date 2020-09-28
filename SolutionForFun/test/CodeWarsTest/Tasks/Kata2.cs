using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.Tasks
{
    public static partial class Kata
    {
        public static int FirstDuplicate(int[] a)
        {
            var hs = new HashSet<int>();
            foreach (var t in a)
            {
                if (hs.Contains(t))
                    return t;
                hs.Add(t);
            }
            return -1;
        }

        public static int CenturyFromYear(int year)
        {
            return --year / 100 + 1;
        }

        public static bool CheckPalindrome(string inputString)
        {
            //return new string(inputString.Reverse().ToArray()) == inputString;
            return inputString.SequenceEqual(inputString.Reverse());
        }

        public static int AdjacentElementsProduct(int[] inputArray)
        {
            var max = int.MinValue;
            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                var s = inputArray[i] * inputArray[i + 1];
                if (s > max)
                {
                    max = s;
                }
            }

            return max;
        }

        public static bool ContainsDuplicates(int[] a)
        {
            return a.Length != a.Distinct().Count();
        }

        public static string AmendTheSentence(string s)
        {
            return Regex.Replace(s, "[A-Z]", m => " " + m.Value.ToLower()).Trim();
        }

        //Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        public static int MatrixElementsSum(int[][] matrix)
        {
            var sum = 0;
            for (var i = 0; i < matrix[0].Length; i++)
            {
                for (var j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                {
                    sum += matrix[j][i];
                }
            }

            return sum;
        }

        //Given an array of strings, return another array containing all of its longest strings.
        public static string[] AllLongestStrings(string[] inputArray)
        {
            var ordered = inputArray.OrderByDescending(x => x.Length).ToList();
            var biggest = ordered.First().Length;

            return ordered.TakeWhile(x => x.Length == biggest).ToArray();
        }

        //Given two strings, find the number of common characters between them
        public static int CommonCharacterCount(string s1, string s2)
        {
            var count = 0;
            foreach (var index in s1.Select(c => s2.IndexOf(c)).Where(index => index >= 0))
            {
                s2 = s2.Remove(index, 1);
                count++;
            }

            return count;
        }

        /*
         * Ticket numbers usually consist of an even number of digits.
         * A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.
         * Given a ticket number n, determine if it's lucky or not.
         */
        public static bool IsLucky(int n)
        {
            var number = n.ToString();
            var firstHalf = number.Take(number.Length / 2).Sum(c => int.Parse(c.ToString()));
            var secondHalf = number.TakeLast(number.Length / 2).Sum(c => int.Parse(c.ToString()));

            return firstHalf == secondHalf;
        }

        /*
         * Some people are standing in a row in a park.
         * There are trees between them which cannot be moved.
         * Your task is to rearrange the people by their heights in a non-descending order without moving the trees. People can be very tall!
         * Example
         * For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
         * sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
         */
        public static int[] SortByHeight(int[] a)
        {
            var orderedList = a.Where(x => x > 0).OrderBy(h => h).ToList();
            var index = 0;
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    a[i] = orderedList[index++];
                }
            }

            return a;
        }


        /*
         * Write a function that reverses characters in (possibly nested) parentheses in the input string.
         * Input strings will always be well-formed with matching ()s.
         * For inputString = "(bar)", the output should be reverseInParentheses(inputString) = "rab";
         */
        public static string ReverseInParentheses(string inputString)
        {
            static string ReverseString(string str)
            {
                var array = str.ToCharArray().Skip(1).SkipLast(1).ToArray();
                Array.Reverse(array);
                return new string(array);
            }

            while (inputString.Contains("("))
            {
                inputString = Regex.Replace(inputString, @"\(\)|\(([^\) ^\(]+)\)", m => ReverseString(m.Value));
            }

            return inputString;
        }

        /*
         * Several people are standing in a row and need to be divided into two teams.
         * The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.
         * You are given an array of positive integers - the weights of the people.
         * Return an array of two integers, where the first element is the total weight of team 1, and the second element is the total weight of team 2 after the division is complete.
         */
        public static int[] AlternatingSums(int[] a)
        {
            var array = new int[] { 0, 0 };

            for (int i = 0; i < a.Length; i++)
            {
                array[i % 2] += a[i];
            }

            return array;
        }

        public static string[] AddBorder(string[] picture)
        {
            //var array = new string[picture.Length + 2];
            //Array.Fill<string>(array, string.Concat(Enumerable.Repeat("*", picture[0].Length + 2)));

            //for (int i = 0; i < picture.Length; i++)
            //{
            //    array[i + 1] = $"*{picture[i]}*";
            //}
            //return array;
            var stars = new string[] { new string('*', picture[0].Length + 2) };
            return stars.Concat(picture.Select(p => $"*{p}*"))
                .Concat(stars)
                .ToArray();
        }
    }
}
