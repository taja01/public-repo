using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.Tasks
{
    public static class Kata
    {
        /*
         * Trolls are attacking your comment section!
         * A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
         * Your task is to write a function that takes a string and return a new string with all vowels removed.
         * For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
         * Note: for this kata y isn't considered a vowel.
         */
        public static string Disemvowel(string str)
        {
            return new string(str.Where(c => !"aeiuoAEIOU".Contains(c)).ToArray());
        }

        /*
         * Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others.
         * Bob observed that one number usually differs from the others in evenness.
         * Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
         * ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)
         */
        public static bool XO(string input)
        {
            var xCount = input.ToLower().Count(c => c == 'x');
            var oCount = input.ToLower().Count(c => c == 'o');

            return xCount == oCount;
        }

        public static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }

        //Write a function called repeatString which repeats the given String src exactly count times.
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }

        //You probably know the "like" system from Facebook and other pages.
        //People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }

        /*
         * The Western Suburbs Croquet Club has two categories of membership, Senior and Open.
         * They would like your help with an application form that will tell prospective members which category they will be placed.
         * To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
         * In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
         */

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
            //var member = new List<string>();
            //foreach (var d in data)
            //{
            //    if (d[0] >= 55 && d[1] > 7)
            //    {
            //        member.Add("Senior");
            //    }
            //    else
            //    {
            //        member.Add("Open");
            //    }
            //}

            //return member;
        }

        //Remove First and Last Character
        public static string Remove_char(string s)
        {
            return s.Length < 2 ? "ok" : s.Substring(1, s.Length - 2);
        }

        //Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers.
        //No floats or non-positive integers will be passed.
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }

        //The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned.
        //Valid decimal values for RGB are 0 - 255.
        //Any values that fall out of that range must be rounded to the closest valid value.
        //Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
        public static string Rgb(int r, int g, int b)
        {
            static int Round(int n)
            {
                var c = n > 255 ? 255 : n < 0 ? 0 : n;
                return c;
            }

            return $"{Round(r).ToString("X2")}{Round(g).ToString("X2")}{Round(b).ToString("X2")}";
        }

        //Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }

        //Given n, take the sum of the digits of n.
        //If that value has more than one digit, continue reducing in this way until a single-digit number is produced.
        //This is only applicable to the natural numbers.
        public static int DigitalRoot(long n)
        {
            var s = n.ToString().Sum(c => long.Parse(c.ToString()));

            if (s > 10)
            {
                s = DigitalRoot(s);
            }

            return (int)s;
        }
    }
}
