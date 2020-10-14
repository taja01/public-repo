using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.Tasks
{
    public static partial class Kata
    {
        /*
         * Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.
         */
        public static bool AreSimilar(int[] a, int[] b)
        {
            var d = a.Zip(b, (i, j) => i != j).Count(x => x == true);
            return d <= 2 && a.Intersect(b).Count() == a.Length;
        }

        /*
         * You are given an array of integers. On each move you are allowed to increase exactly one of its element by one. 
         * Find the minimal number of moves required to obtain a strictly increasing sequence from the input.
         */
        public static int ArrayChange(int[] inputArray)
        {
            //var prev = inputArray[0] - 1;
            //return inputArray.Sum(x => (prev = Math.Max(prev + 1, x)) - x);
            var c = 0;

            for (var i = 1; i < inputArray.Length; i++)
            {
                var prev = inputArray[i - 1];
                var current = inputArray[i];
                if (current <= prev)
                {
                    prev = prev + 1;
                    c += prev - current;
                    inputArray[i] = prev;
                }
            }

            return c;
        }

        /*
         * Call two arms equally strong if the heaviest weights they each are able to lift are equal.
         * Call two people equally strong if their strongest arms are equally strong (the strongest arm can be both the right and the left), and so are their weakest arms.
         * Given your and your friend's arms' lifting capabilities find out if you two are equally strong.
         */
        public static bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return Math.Max(yourLeft, yourRight) == Math.Max(friendsLeft, friendsRight)
                && Math.Min(yourLeft, yourRight) == Math.Min(friendsLeft, friendsRight);
        }

        //Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
        public static int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            var max = 0;

            for (int i = 1; i < inputArray.Length; i++)
            {
                max = Math.Max(max, Math.Abs(inputArray[i - 1] - inputArray[i]));
            }

            return max;
        }

        /*
         * An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. 
         * There are two versions of the Internet protocol, and thus two versions of addresses. 
         * One of them is the IPv4 address.
         */

        public static bool IsIPv4Address(string inputString)
        {
            //0
            //return System.Net.IPAddress.TryParse(inputString, out _);

            //1
            if (Regex.IsMatch(inputString, @"^(([0-9]|[1-9][0-9]|[1][0-9][0-9]|[2][0-5][0-9])\.){3}([0-9]|[1-9][0-9]|[1][0-9][0-9]|[2][0-5][0-9])$"))
            {
                var array = inputString.Split('.');

                foreach (var item in array)
                {
                    if (int.TryParse(item, out var result))
                    {
                        if (result > 255)
                            return false;
                    }
                }

                return true;
            }

            return false;
        }

        // take the first element from an array, then the last, then the second, then the last but one in an alternating way.
        //return Boolean whether the elements are sorted

        public static bool AlternatingSort(int[] a)
        {

            var d = new int[a.Length];
            var j = 0;
            var k = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    d[i] = a[j++];
                }
                else
                {
                    d[i] = a[k--];
                }
            }

            for (int i = 1; i < d.Length; i++)
            {
                if (d[i - 1] >= d[i])
                {
                    return false;
                }
            }

            return true;
        }

        /*
         * Given 2 strings, merge them in an alternate way, i.e. the final string’s first character is the first character of the first string, 
         * the second character of the final string is the first character of the second string and so on. And if once you reach end of one string while 
         * if another string is still remaining then append the remaining of that string to final string
         */
        public static string MergeStrings(string s1, string s2)
        {
            var str = string.Empty;

            var s1_index = 0;
            var s2_index = 0;

            for (int i = 0; i < s1.Length + s2.Length; i++)
            {
                if (s1_index < s1.Length)
                {
                    str += s1[s1_index++];
                }

                if (s2_index < s2.Length)
                {
                    str += s2[s2_index++];
                }
            }

            return str;
        }


        //Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.
        public static int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return inputArray.Select(_ => _ == elemToReplace ? substitutionElem : _).ToArray();
        }

        //Check if all digits of the given integer are even.
        public static bool EvenDigitsOnly(int n)
        {
            return n.ToString().All(_ => _ % 2 < 1);
        }
    }
}
