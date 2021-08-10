using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.Tasks
{
    /// <summary>
    /// Low level, for interview
    /// </summary>
    public partial class Kata
    {
        // Convert a Boolean to a String
        public static string Boolean2String(bool b)
        {
            return b.ToString();
        }

        //Hex to Decimal
        public static int HexToDec(string hexString)
        {
            var i = 1;
            if (hexString.Contains('-'))
            {
                hexString = hexString.Replace('-', ' ');
                i = -1;
            }
            return int.Parse(hexString.ToUpper(), System.Globalization.NumberStyles.HexNumber) * i;
        }

        //In this simple assignment you are given a number and have to make it negative.
        //But maybe the number is already negative?
        public static int MakeNegative(int number)
        {
            // return number < 0 ? number : number * -1; 
            return -Math.Abs(number);
        }

        //Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max, with the step.
        //The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min < max)
        public static int[] GenerateRange(int min, int max, int step)
        {
            var list = new List<int>();

            while (min <= max)
            {
                list.Add(min);
                min += step;
            }

            return list.ToArray();
        }

        //Complete the square sum function so that it squares each number passed into it and then sums the results together.
        public static int SquareSum(int[] n)
        {
            //return (int)n.Sum(x => Math.Pow(x, 2));
            return n.Sum(x => x * x);

            /*
                |                   Method       |      Mean |    Error |   StdDev |
                |------------------------------- |----------:|---------:|---------:|
                |             TestShortSquareSum |  28.11 ns | 0.584 ns | 1.023 ns |
                |     TestShortSquareSumWithMath |  77.28 ns | 1.464 ns | 3.619 ns |
                |            TestMediumSquareSum |  27.79 ns | 0.558 ns | 0.620 ns |
                |    TestMediumSquareSumWithMath |  88.85 ns | 1.550 ns | 1.294 ns |
                |               TestBigSquareSum |  56.80 ns | 1.090 ns | 1.020 ns |
                |       TestBigSquareSumWithMath | 240.60 ns | 4.710 ns | 5.424 ns |
             */
        }

        //Create a function (or write a script in Shell) that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

        //Return the number (count) of vowels in the given string.
        public static int GetVowelCount(string str)
        {
            return str.Count(x => "aeiou".Contains(x));

        }

        //Complete the solution so that it reverses the string passed into it.
        public static string Solution(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }

        //Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
        public static string BoolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }

        //Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.
        public static int summation(int num)
        {
            //return Enumerable.Range(1, num).Sum();
            return num * (num + 1) / 2;

            /*
             * Short: 2 -> 1+2 = 3
              * Big: 10000 -> 1+2+3...= 50005000
             |                   Method |           Mean |       Error |        StdDev |         Median |
             |------------------------- |---------------:|------------:|--------------:|---------------:|
             | TestShortSimpleSummation |      0.2260 ns |   0.0781 ns |     0.2303 ns |      0.1827 ns |
             |   TestShortSummationLinq |     28.5884 ns |   0.5933 ns |     1.6243 ns |     28.1154 ns |
             |         TestBigSummation |      0.1673 ns |   0.0719 ns |     0.2120 ns |      0.0062 ns |
             |     TestBigSummationLinq | 34,442.3346 ns | 688.7273 ns | 1,753.0308 ns | 34,275.5463 ns |
            */
        }

        // Simple, remove the spaces from the string, then return the resultant string.
        public static string NoSpace(string input)
        {
            return input.Replace(" ", string.Empty);
        }
    }
}
