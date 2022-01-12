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
    }
}
