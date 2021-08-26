using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

        //Given an array of integers your solution should find the smallest integer.
        public static int FindSmallestInt(int[] args)
        {
            //return args.OrderBy(x => x).First();
            return args.Min();
        }

        //We need a function that can transform a number into a string.
        public static string NumberToString(int num)
        {
            return num.ToString();
        }

        //Consider an array/list of sheep where some sheep may be missing from their place.
        //We need a function that counts the number of sheep present in the array (true means present).
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(x => x);
        }

        /*
         * It's bonus time in the big city! The fatcats are rubbing their paws in anticipation... but who is going to make the most money?
         * Build a function that takes in two arguments (salary, bonus). Salary will be an integer, and bonus a boolean.
         * If bonus is true, the salary should be multiplied by 10. If bonus is false, the fatcat did not make enough money and must receive only his stated salary.
         */
        public static string BonusTime(int salary, bool bonus)
        {
            return $"${salary * (bonus ? 10 : 1)}";
        }

        /*
         * Nathan loves cycling.
         * Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
         * You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.
         */
        public static int Litres(double time)
        {
            return (int)(time / 2);
        }

        /*
         * An NBA game runs 48 minutes (Four 12 minute quarters). Players do not typically play the full game, subbing in and out as necessary. 
         * Your job is to extrapolate a player's points per game if they played the full 48 minutes.
         * Write a function that takes two arguments, ppg (points per game) and mpg (minutes per game) and returns a straight extrapolation of ppg per 48 minutes rounded to the nearest tenth. Return 0 if 0.
         */
        public static double NbaExtrap(double ppg, double mpg)
        {
            return ppg == 0 ? 0 : Math.Round(ppg / mpg * 48, 1);
        }

        //Remove a exclamation mark from the end of string.
        //For a beginner kata, you can assume that the input data is always a string, no need to verify it.
        public static string Remove(string s)
        {
            return s.EndsWith("!") ? s.Substring(0, s.Length - 1) : s;
            //return s.EndsWith("!") ? s[0..^1] : s;
        }

        /*
         * Given two integer arrays a, b, both of length >= 1, create a program that 
         * returns true if the sum of the squares of each element in a is strictly greater than the sum of the cubes of each element in b.
         */
        public static bool ArrayMadness(int[] a, int[] b)
        {
            var aa = a.Select(x => x * x).Sum();
            var bb = b.Select(x => x * x * x).Sum();

            return aa > bb;
        }

        //Take an array and remove every second element from the array.
        //Always keep the first element and start removing with the next element.
        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr.Where((x, y) => y % 2 == 0).ToArray();
        }

        //Basic regex tasks. Write a function that takes in a numeric code of any length.
        //The function should check if the code begins with 1, 2, or 3 and return
        public static bool ValidateCode(string code)
        {
            var pattern = "^[1-3]";
            return Regex.IsMatch(code, pattern);
        }

        //Create a method that accepts a list and an item, and returns true if the item belongs to the list, otherwise false.
        public static bool Include(int[] arr, int item)
        {
            return arr.Contains(item);
        }

        /*
         * Character recognition software is widely used to digitise printed texts. Thus the texts can be edited, searched and stored on a computer.
         * When documents (especially pretty old ones written with a typewriter), are digitised character recognition softwares often make mistakes.
         * Your task is correct the errors in the digitised text. You only have to handle the following mistakes:
         * S is misinterpreted as 5
         * O is misinterpreted as 0
         * I is misinterpreted as 1
         * The test cases contain numbers only by mistake.
         */
        public static string Correct(string text)
        {
            return text
                .Replace("0", "O")
                .Replace("1", "I")
                .Replace("5", "S");
        }

        public static double basicOp(char operation, double value1, double value2)
        {
            return operation switch
            {
                '+' => value1 + value2,
                '-' => value1 - value2,
                '*' => value1 * value2,
                '/' => value1 / value2,
                _ => throw new NotImplementedException(),
            };
        }

        /*
         * In this example you have to validate if a user input string is alphanumeric. The given string is not nil/null/NULL/None, so you don't have to check that.
         * The string has the following conditions to be alphanumeric:
         * At least one character ("" is not valid)
         * Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
         * No whitespaces / underscore
         */
        public static bool Alphanumeric(string str)
        {

            return !string.IsNullOrEmpty(str) && str.All(c => char.IsLetterOrDigit(c));
        }
    }
}
