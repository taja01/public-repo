﻿using System.Text.RegularExpressions;

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
    }
}
