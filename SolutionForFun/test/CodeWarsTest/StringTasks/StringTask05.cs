using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
        * https://www.codewars.com/kata/5b5e0c0d83d64866bc00001d
        * You have a string of numbers; starting with the third number each number is the result of an operation performed using the previous two numbers.
        * Complete the function which returns a string of the operations in order and separated by a comma and a space, e.g. "subtraction, subtraction, addition"
        */
        public static string SayMeOperations(string stringNumbers)
        {
            var arr = stringNumbers.Split(' ').Select(x => int.Parse(x)).ToList();
            //var operation = new List<string>();

            //for (int i = 1; i < arr.Count() - 1; i++)
            //{
            //    if (arr[i - 1] + arr[i] == arr[i + 1])
            //    {
            //        operation.Add("addition");
            //    }
            //    else if (arr[i - 1] * arr[i] == arr[i + 1])
            //    {
            //        operation.Add("multiplication");
            //    }
            //    else if (arr[i - 1] - arr[i] == arr[i + 1])
            //    {
            //        operation.Add("subtraction");
            //    }
            //    else
            //    {
            //        operation.Add("division");
            //    }
            //}

            //return string.Join(", ", operation);

            return string.Join(", ", Enumerable.Range(0, arr.Count() - 2).Select(i =>
                        arr[i] + arr[i + 1] == arr[i + 2] ? "addition" :
                        arr[i] - arr[i + 1] == arr[i + 2] ? "subtraction" :
                        arr[i] * arr[i + 1] == arr[i + 2] ? "multiplication" : "division"));
        }

        /*
         * https://www.codewars.com/kata/5b39e3772ae7545f650000fc
         * Your task is to remove all duplicate words from a string, leaving only single (first) words entries.
         * Example:
         * Input:
         * 'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'
         * Output:
         * 'alpha beta gamma delta'
         */
        public static string RemoveDuplicateWords(string s)
        {
            return string.Join(' ', s.Split(' ').Distinct());
        }

        /*
         * https://www.codewars.com/kata/5b37a50642b27ebf2e000010
         * Beaches are filled with sand, water, fish, and sun.
         * Given a string, calculate how many times the words "Sand", "Water", "Fish", and "Sun" appear without overlapping (regardless of the case).
         */
        public static int SumOfABeach(string s)
        {
            return Regex.Matches(s, "(sand|fish|water|sun)", RegexOptions.IgnoreCase).Count;
        }

        /*
         * https://www.codewars.com/kata/5b358a1e228d316283001892
         * You receive the name of a city as a string, and you need to return a string that shows how many times each letter shows up in the string by using asterisks (*).
         * "Chicago"  -->  "c:**,h:*,i:*,a:*,g:*,o:*"
         */
        public static string GetStrings(string city)
        {
            return string.Join(',', city.ToLower()
                .GroupBy(c => c)
                .Where(c => char.IsLetter(c.Key))
                .Select(x => $"{x.Key}:{new string('*', x.Count())}"));
        }

        /*
         * https://www.codewars.com/kata/5d076515e102162ac0dc514e
         * Create a function, as short as possible, that returns this lyrics.
         * Your code should be less than 300 characters. Watch out for the three points at the end of the song.
         */
        public static string BabySharkLyrics()
        {
            //var l = new List<string>();
            //var f = new[] { "Baby", "Mommy", "Daddy", "Grandma", "Grandpa", "Let's go hunt" };

            //for (int i = 0; i < f.Length; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        l.Add($"{f[i]}{(i < 5 ? " shark" : "")}{(j < 3 ? ", doo doo doo doo doo doo" : "!")}");
            //    }
            //}
            //l.Add("Run away,…");
            //l.Add("");

            //return string.Join('\n', l);

            return string.Concat(new[] { "Baby", "Mommy", "Daddy", "Grandma", "Grandpa" }
            .Select(x => $"{x} shark")
            .Append("Let's go hunt")
            .Select(y => string.Join(", doo doo doo doo doo doo\n", Enumerable.Repeat(y, 4)) + "!\n")) + "Run away,…\n";
        }

        /*
         * https://www.codewars.com/kata/5acbc3b3481ebb23a400007d
         * Determine if the poker hand is flush, meaning if the five cards are of the same suit.
         * Your function will be passed a list/array of 5 strings, each representing a poker card in the format "5H" (5 of hearts), meaning the value of the card followed by the initial of its suit (Hearts, Spades, Diamonds or Clubs). No jokers included.
         */
        public static bool CheckIfFlush(string[] cards)
        {
            var c = cards[0].Last();
            return cards.All(x => x.Last() == c);
        }

        /*
         * https://www.codewars.com/kata/5a87449ab1710171300000fd
         * A Tidy number is a number whose digits are in non-decreasing order.
         * Given a number, Find if it is Tidy or not.
         * Number passed is always Positive.
         * Return the result as a Boolean
         * tidyNumber (12) ==> return (true)
         * The number's digits { 1 , 2 } are in non-Decreasing Order (i.e) 1 <= 2.
         * tidyNumber (32) ==> return (false)
         * The Number's Digits { 3, 2} are not in non-Decreasing Order (i.e) 3 > 2 .
         * tidyNumber (1024) ==> return (false)
         * The Number's Digits {1 , 0, 2, 4} are not in non-Decreasing Order as 0 <= 1 
         */
        public static bool TidyNumber(int n)
        {
            //var array = n.ToString().ToArray();
            //for (var i = 1; i < array.Length; i++)
            //{
            //    if (array[i - 1] > array[i])
            //    {
            //        return false;
            //    }
            //}

            //return true;

            return n.ToString().SequenceEqual(n.ToString().OrderBy(x => x));
        }

        /*
         * https://www.codewars.com/kata/5a731b36e19d14400f000c19
         * Password Check - Binary to String
         * A wealthy client has forgotten the password to his business website, but he has a list of possible passwords.
         * His previous developer has left a file on the server with the name password.txt.
         * You open the file and realize it's in binary format.
         * Write a script that takes an array of possible passwords and a string of binary representing the possible password.
         * Convert the binary to a string and compare to the password array.
         * If the password is found, return the password string, else return false;
         */
        public static string DecodePass(string[] passArr, string bin)
        {
            //var byteList = (bin.Split(' ').Select(item => Convert.ToByte(item, 2))).ToList();
            //var b = Encoding.ASCII.GetString(byteList.ToArray());

            //return passArr.Contains(b) ? b : null;

            var binString = string.Concat(bin.Split().Select(x => (char)Convert.ToInt32(x, 2)));
            return passArr.Contains(binString) ? binString : null;
        }
    }
}
