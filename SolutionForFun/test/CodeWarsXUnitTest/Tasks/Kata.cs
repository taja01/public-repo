﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        public static int SumTwoSmallestNumbers(int[] numbers)
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

        //Polycarpus works as a DJ in the best Berland nightclub, and he often uses dubstep music in his performance.
        //Recently, he has decided to take a couple of old songs and make dubstep remixes from them.
        //Let's assume that a song consists of some number of words (that don't contain WUB).
        //To make the dubstep remix of this song, Polycarpus inserts a certain number of words "WUB" before the first word of the song (the number may be zero),
        //after the last word (the number may be zero), and between words (at least one between any pair of neighbouring words),
        //and then the boy glues together all the words, including "WUB", in one string and plays the song at the club.
        public static string SongDecoder(string input)
        {
            return Regex.Replace(input, "(WUB)+", " ").Trim();
        }

        public static int Multiples3_5(int value)
        {
            return Enumerable
                 .Range(0, value)
                 .Where(i => (i % 3 == 0 || i % 5 == 0))
                 .Sum();
        }

        //Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid.
        //The function should return true if the string is valid, and false if it's invalid.
        public static bool ValidParentheses(string input)
        {
            var parentheses = 0;
            foreach (char t in input)
            {
                if (t == '(')
                {
                    parentheses++;
                }
                else if (t == ')')
                {
                    parentheses--;

                    if (parentheses < 0)
                    {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }

        //Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.
        //The function must accept a non-negative integer. If it is zero, it just returns "now".
        //Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.
        public static string FormatDuration(int seconds)
        {
            int RemainSeconds(int currentRange, string nameOfRange, ref string str1)
            {
                var usedRange = seconds / currentRange;
                seconds %= currentRange;

                if (usedRange <= 0)
                {
                    return seconds;
                }

                var s = usedRange > 1 ? "s" : "";
                if (string.IsNullOrEmpty(str1))
                {
                    str1 = $"{usedRange} {nameOfRange}{s}";
                }
                else
                {
                    var extend = seconds > 0 ? ", " : " and ";
                    str1 += $"{extend}{usedRange} {nameOfRange}{s}";
                }

                return seconds;
            }

            if (seconds == 0)
            {
                return "now";
            }
            var str = string.Empty;
            var sec_in_min = 60;
            var min_in_hour = sec_in_min * 60;
            var hour_in_day = min_in_hour * 24;
            var day_in_year = hour_in_day * 365;

            seconds = RemainSeconds(day_in_year, "year", ref str);
            seconds = RemainSeconds(hour_in_day, "day", ref str);
            seconds = RemainSeconds(min_in_hour, "hour", ref str);
            seconds = RemainSeconds(sec_in_min, "minute", ref str);
            seconds = RemainSeconds(1, "second", ref str);

            return str;
        }

        public static int FirstDuplicate(int[] a)
        {
            var hs = new HashSet<int>();
            foreach (var t in a)
            {
                if (hs.Contains(t))
                    return t;
                hs.Add(t);
            }
            return -1;
        }

        public static int CenturyFromYear(int year)
        {
            return --year / 100 + 1;
        }

        public static bool CheckPalindrome(string inputString)
        {
            //return new string(inputString.Reverse().ToArray()) == inputString;
            return inputString.SequenceEqual(inputString.Reverse());
        }

        public static int AdjacentElementsProduct(int[] inputArray)
        {
            var max = int.MinValue;
            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                var s = inputArray[i] * inputArray[i + 1];
                if (s > max)
                {
                    max = s;
                }
            }

            return max;
        }

        public static bool ContainsDuplicates(int[] a)
        {
            return a.Length != a.Distinct().Count();
        }

        public static string AmendTheSentence(string s)
        {
            return Regex.Replace(s, "[A-Z]", m => " " + m.Value.ToLower()).Trim();
        }

        //Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        public static int MatrixElementsSum(int[][] matrix)
        {
            var sum = 0;
            for (var i = 0; i < matrix[0].Length; i++)
            {
                for (var j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                {
                    sum += matrix[j][i];
                }
            }

            return sum;
        }

        //Given an array of strings, return another array containing all of its longest strings.
        public static string[] AllLongestStrings(string[] inputArray)
        {
            var ordered = inputArray.OrderByDescending(x => x.Length).ToList();
            var biggest = ordered.First().Length;

            return ordered.TakeWhile(x => x.Length == biggest).ToArray();
        }

        //Given two strings, find the number of common characters between them
        public static int CommonCharacterCount(string s1, string s2)
        {
            var count = 0;
            foreach (var index in s1.Select(c => s2.IndexOf(c)).Where(index => index >= 0))
            {
                s2 = s2.Remove(index, 1);
                count++;
            }

            return count;
        }

        /*
         * Ticket numbers usually consist of an even number of digits.
         * A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.
         * Given a ticket number n, determine if it's lucky or not.
         */
        public static bool IsLucky(int n)
        {
            var number = n.ToString();
            var firstHalf = number.Take(number.Length / 2).Sum(c => int.Parse(c.ToString()));
            var secondHalf = number.TakeLast(number.Length / 2).Sum(c => int.Parse(c.ToString()));

            return firstHalf == secondHalf;
        }

        /*
         * Some people are standing in a row in a park.
         * There are trees between them which cannot be moved.
         * Your task is to rearrange the people by their heights in a non-descending order without moving the trees. People can be very tall!
         * Example
         * For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
         * sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
         */
        public static int[] SortByHeight(int[] a)
        {
            var orderedList = a.Where(x => x > 0).OrderBy(h => h).ToList();
            var index = 0;
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    a[i] = orderedList[index++];
                }
            }

            return a;
        }

    }
}
