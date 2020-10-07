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


    }
}
