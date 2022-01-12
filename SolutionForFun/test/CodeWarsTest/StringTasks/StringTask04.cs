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

        /*
         * https://www.codewars.com/kata/605ae9e1d2be8a0023b494ed
         * There is a narrow hallway in which people can go right and left only. 
         * When two people meet in the hallway, by tradition they must salute each other. People move at the same speed left and right.
         * Your task is to write a function that, given a string representation of people moving in the hallway, will count the number of salutes that will occur.
         * Note: 2 salutes occur when people meet, one to the other and vice versa.
         * Input: <---<--->----<
         * Output: 2
         * 
         * Input: >----->-----<--<
         * Output: 8
         */
        public static int CountSalutes(string hallway)
        {
            var counter = 0;
            var text = hallway.Replace("-", string.Empty);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    continue;
                }
                counter += text.Substring(i).Count(c => c == '<');
            }

            return counter * 2;
        }

        /*
         * https://www.codewars.com/kata/5e2596a9ad937f002e510435
         * ⚠️ The world is in quarantine! There is a new pandemia that struggles mankind.
         * Each continent is isolated from each other but infected people have spread before the warning. ⚠️
         * 🗺️ You would be given a map of the world in a type of string:
         * string s = "01000000X000X011X0X"
         * '0' : uninfected
         * '1' : infected
         * 'X' : ocean
         * Example:
         * start: map1 = "01000000X000X011X0X"
         * end:   map1 = "11111111X000X111X0X"
         * total = 15
         * infected = 11
         * percentage = 100*11/15 = 73.33333333333333
         */
        public static double Infected(string s)
        {
            var cases = s.Split('X').Where(x => x.Contains('1')).Sum(x => x.Length);

            return cases == 0
                ? 0
                : 100 * (double)cases / s.Count(char.IsNumber);
        }

        /*
         * https://www.codewars.com/kata/5a19701d80171fd71d000029
         * This cipher involves taking each character of a string and multiplying their char codes by 6.
         * For example, `Hello World!` would become `ưɞʈʈʚÀȊʚʬʈɘÆ`.
         * You must write two functions:
         * `encode` to encode a given string,
         * `decode` to decode a given string.
         */
        public static string Encode(string str)
        {
            return string.Concat(str.Select(x => char.ConvertFromUtf32(x * 6)));
        }

        public static string Decode(string str)
        {
            return string.Concat(str.Select(x => char.ConvertFromUtf32(x / 6)));
        }
    }
}
