using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/53af2b8861023f1d88000832
         * Create a function which answers the question "Are you playing banjo?".
         * If your name starts with the letter "R" or lower case "r", you are playing banjo!
         * The function takes a name as its only argument, and returns one of the following strings:
         * name + " plays banjo" 
         * name + " does not play banjo"
         * Names given are always valid strings.
         */
        public static string AreYouPlayingBanjo(string name)
        {
            return name.ToLower().StartsWith("r")
                ? $"{name} plays banjo"
                : $"{name} does not play banjo";
        }

        /*
         * https://www.codewars.com/kata/563b74ddd19a3ad462000054
         * write me a function stringy that takes a size and returns a string of alternating '1s' and '0s'.
         * the string should start with a 1.
         * a string with size 6 should return :'101010'.
         * with size 4 should return : '1010'.
         * with size 12 should return : '101010101010'.
         * The size will always be positive and will only use whole numbers.
         */
        public static string Stringy(int size)
        {
            return string.Join("", Enumerable.Range(0, size).Select(x => (x + 1) % 2));
        }

        /*
         * https://www.codewars.com/kata/568dc014440f03b13900001d
         */

        public static string GetDrinkByProfession(string p)
        {
            return p.ToLower() switch
            {
                string a when a.Contains("jabroni") => "Patron Tequila",
                string a when a.Contains("school counselor") => "Anything with Alcohol",
                string a when a.Contains("programmer") => "Hipster Craft Beer",
                string a when a.Contains("gang member") => "Moonshine",
                string a when a.Contains("politician") => "Your tax dollars",
                string a when a.Contains("rapper") => "Cristal",
                _ => "Beer",
            };
        }

        /*
         * https://www.codewars.com/kata/56a946cd7bd95ccab2000055
         * Your task is simply to count the total number of lowercase letters in a string.
         */
        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, "[a-z]").Count;
        }

        /*
         * https://www.codewars.com/kata/55ccdf1512938ce3ac000056
         */
        public static bool IsLockNessMonster(string sentence)
        {
            return Regex.IsMatch(sentence, "tree fiddy|3.50", RegexOptions.IgnoreCase);
        }

        /*
         * https://www.codewars.com/kata/570597e258b58f6edc00230d
         * You are given a string containing a sequence of character sequences separated by commas.
         * Write a function which returns a new string containing the same character sequences except the first and
         * the last ones but this time separated by spaces.
         * If the input string is empty or the removal of the first and last items would cause the resulting string to be empty,
         * return an empty value (represented as a generic value NULL in the examples below).
         */
        public static string Array(string s)
        {
            //var a = string.Join(" ", s.Split(",").Skip(1).SkipLast(1));
            //return a.Length == 0 ? null : a;
            var arr = s.Split(",");
            return arr.Length > 2
                ? string.Join(" ", arr[1..^1])
                : null;
        }

        /*
         * https://www.codewars.com/kata/580a094553bd9ec5d800007d
         */
        public static string Apple(object n)
        {
            return int.TryParse(n.ToString(), out var result) && result * result > 1000
                ? "It's hotter than the sun!!"
                : "Help yourself to a honeycomb Yorkie for the glovebox.";
        }

        /*
         * https://www.codewars.com/kata/57e921d8b36340f1fd000059
         */
        public static string Shark(int pontoonDistance, int sharkDistance, int yourSpeed, int sharkSpeed, bool dolphin)
        {
            //your code here
            // v = s/t -> t = s/v

            var a = (double)pontoonDistance / yourSpeed;
            var b = (double)sharkDistance / (dolphin ? sharkSpeed / 2 : sharkSpeed);
            return a < b ? "Alive!" : "Shark Bait!";
        }

        /*
         * https://www.codewars.com/kata/51c8991dee245d7ddf00000e
         * "The greatest victory is that which requires no battle" --> "battle no requires which that is victory greatest The"
         */
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(" ").Reverse());
        }

        /*
         * https://www.codewars.com/kata/57ec8bd8f670e9a47a000f89
         * The wide-mouth frog is particularly interested in the eating habits of other creatures.
         * He just can't stop asking the creatures he encounters what they like to eat. 
         * But, then he meets the alligator who just LOVES to eat wide-mouthed frogs!
         * When he meets the alligator, it then makes a tiny mouth.
         * Your goal in this kata is to create complete the mouth_size method this method takes one argument animal which corresponds to the animal encountered by the frog. 
         * If this one is an alligator (case-insensitive) return small otherwise return wide
         */
        public static string MouthSize(string animal)
        {
            return animal.ToLower() == "alligator"
                ? "small"
                : "wide";
        }

        /*
         * https://www.codewars.com/kata/57eaeb9578748ff92a000009
         * Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.
         * Return your answer as a number.
         */
        public static int SumMix(object[] x)
        {
            //return (int)x.Sum(y => int.Parse(y.ToString()));
            return x.Sum(Convert.ToInt32);
        }
    }
}
