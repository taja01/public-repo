﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.Tasks
{
    public partial class Kata
    {
        //Create a function called shortcut to remove all the lowercase vowels in a given string.
        public static string Shortcut(string input)
        {
            //var vowels = "aeiou";
            //return new string(input.Where(c => !vowels.Contains(c)).ToArray());

            return Regex.Replace(input, "[aiuoe]", "");
        }

        /*
         * https://www.codewars.com/kata/59ca8246d751df55cc00014c
         * A hero is on his way to the castle to complete his mission. 
         * However, he's been told that the castle is surrounded with a couple of powerful dragons! 
         * each dragon takes 2 bullets to be defeated,
         * our hero has no idea how many bullets he should carry.. 
         * Assuming he's gonna grab a specific given number of bullets and move forward to fight another specific given number of dragons, 
         * will he survive?
         */
        public static bool Hero(int bullets, int dragons)
        {
            return (bullets / 2) >= dragons;
        }

        /*
         * https://www.codewars.com/kata/568dcc3c7f12767a62000038
         * Write a function named setAlarm which receives two parameters. 
         * The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.
         * The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm).
         * It should return false otherwise.
         */
        public static bool SetAlarm(bool employed, bool vacation)
        {
            return employed & !vacation;
        }

        //https://www.codewars.com/kata/5f70c883e10f9e0001c89673
        public static int[] Flip(char dir, int[] arr)
        {
            //Array.Sort(arr);
            //if (dir == 'L')
            //{
            //    Array.Reverse(arr);
            //}

            //return arr;

            return dir == 'R'
                ? arr.OrderBy(x => x).ToArray()
                : arr.OrderByDescending(x => x).ToArray();
        }

        /*
         * https://www.codewars.com/kata/5bb904724c47249b10000131
         * Total amount of points
         * if x>y - 3 points
         * if x<y - 0 point
         * if x=y - 1 point
         */
        public static int TotalPoints(string[] games)
        {
            //var sum = 0;
            //foreach (var game in games)
            //{
            //    if (game[0] > game[2])
            //    {
            //        sum += 3;
            //    }
            //    else if (game[0] == game[2])
            //    {
            //        sum += 1;
            //    }
            //}

            //return sum;

            return games.Sum(x => x[0] == x[2] ? 1 : x[0] > x[2] ? 3 : 0);
        }

        /*
         * https://www.codewars.com/kata/5b853229cfde412a470000d0
         * Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old).
         */
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(dadYears - sonYears * 2);
        }

        /*
         * https://www.codewars.com/kata/5b077ebdaf15be5c7f000077
         * Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...".
         * Input will always be valid, i.e. no negative integers.
         */
        public static string CountSheep(int n)
        {
            return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
        }
    }
}
