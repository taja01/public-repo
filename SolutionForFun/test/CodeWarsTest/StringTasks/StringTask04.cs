using System;
using System.Linq;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/55a70521798b14d4750000a4
         * Make a function that will return a greeting statement that uses an input; your program should return, "Hello, <name> how are you doing today?".
         * [Make sure you type the exact thing I wrote or the program may not execute properly]
         */
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

        /*
         * https://www.codewars.com/kata/57a5015d72292ddeb8000b31
         * Palindrome strings
         * A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. 
         * This includes capital letters, punctuation, and word dividers.
         * Implement a function that checks if something is a palindrome. 
         * If the input is a number, convert it to string first.
         */
        public static bool IsPalindrome(object line)
        {
            return line.ToString().SequenceEqual(line.ToString().Reverse());
        }

        /*
         * https://www.codewars.com/kata/559f3123e66a7204f000009f
         * You will be given an array of numbers which can be used using the String.fromCharCode() (JS), Tools.FromCharCode() (C#) method to convert the number to a character.
         * It is recommended to map over the array of numbers and convert each number to the corresponding ascii character.
         */
        public static string ArrowFunc(int[] arr)
        {
            //return string.Join("", arr.Select(c => Char.ConvertFromUtf32(c)).ToArray());
            return string.Concat(arr.Select(x => (char)x));
        }

        /*
         * https://www.codewars.com/kata/57a55c8b72292d057b000594
         * You need to write a function that reverses the words in a given string. A word can also fit an empty string. If this is not clear enough, here are some examples:
         * As the input may have trailing spaces, you will also need to ignore unneccesary whitespace.
         */
        public static string Reverse(string text)
        {
            return string.Join(' ', text.Split(' ').Reverse());
        }

        /*
         * https://www.codewars.com/kata/606efc6a9409580033837dfb
         * You have cultivated a plant, and after months of hard work, the time has come to reap the flowers of your hard work. 
         * When it was growing, you added water and fertilizer, and kept a constant temperature. It's time check how much your plant has grown.
         * A plant is represented horizontally, from the base to the left, to the end to the right:
         * ---@---@---@
         */
        public static string Plant(char seed, int water, int fert, int temp)
        {
            //if (temp < 20 || temp > 30)
            //{
            //    return $"{string.Concat(Enumerable.Repeat('-', water * water))}{seed}";
            //}

            //var w = string.Concat(Enumerable.Repeat('-', water));
            //var p = string.Concat(Enumerable.Repeat(seed, fert));

            //return string.Concat(Enumerable.Repeat($"{w}{p}", water));

            return temp < 20 || temp > 30
                ? new string('-', water * water) + seed
                : string.Concat(Enumerable.Repeat(new string('-', water) + new string(seed, fert), water));
        }
    }
}
