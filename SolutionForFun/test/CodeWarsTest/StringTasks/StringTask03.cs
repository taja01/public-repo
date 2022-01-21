using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/57eae65a4321032ce000002d
         * Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'.
         * Return the resulting string.
         * Note: input will never be an empty string
         */
        public static string FakeBin(string x)
        {
            return string.Concat(x.Select(i => i < '5' ? "0" : "1")).ToUpper();
        }

        /*
         * https://www.codewars.com/kata/5556282156230d0e5e000089
         * Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. 
         * It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
         * Ribonucleic acid, RNA, is the primary messenger molecule in cells. 
         * RNA differs slightly from DNA its chemical structure and contains no Thymine. 
         * In RNA Thymine is replaced by another nucleic acid Uracil ('U').
         * Create a function which translates a given DNA string into RNA.
         * For example:
         * "GCAT"  =>  "GCAU"
         */
        public static string DnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }

        /*
         * https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3
         * Write a function to convert a name into initials.
         * This kata strictly takes two words with one space in between them.
         * The output should be two capital letters with a dot separating them.
         * It should look like this:
         * Sam Harris => S.H
         * patrick feeney => P.F
         */
        public static string AbbrevName(string name)
        {
            return string.Join(".", name.Split(" ").Select(x => x[0])).ToUpper();
        }

        /*
         * https://www.codewars.com/kata/57e76bc428d6fbc2d500036d
         * Write a function to split a string and convert it into an array of words. For example:
         * "Robin Singh" ==> ["Robin", "Singh"]
         * "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
         */
        public static string[] StringToArray(string str)
        {
            return str.Split(' ');
        }

        /*
         * https://www.codewars.com/kata/57cff961eca260b71900008f
         * Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).
         * If they are, change the array value to a string of that vowel.
         * Return the resulting array.
         */
        public static object[] IsVow(object[] a)
        {
            object[] vowels = new object[] { 97, 101, 105, 117, 111 };

            return a.Select(x => vowels.Contains(x) ? char.ConvertFromUtf32((int)x) : x).ToArray();
        }

        /*
         * https://www.codewars.com/kata/5302d846be2a9189af0001e4
         * Create a method sayHello/say_hello/SayHello that takes as input a name, city, and state to welcome a person. 
         * Note that name will be an array consisting of one or more values that should be joined together with one space between each, 
         * and the length of the name array in test cases will vary.
         * Kata.SayHello(new String[]{"John", "Smith"}, "Phoenix", "Arizona")
         * This example will return the string Hello, John Smith! Welcome to Phoenix, Arizona!
         */
        public static string SayHello(string[] name, string city, string state)
        {
            return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
        }

        /*
         * https://www.codewars.com/kata/548ef5b7f33a646ea50000b2
         * Welcome, Warrior! In this kata, you will get a message and you will need to get the frequency of each and every character!
         * Your function will be called char_freq/charFreq/CharFreq and you will get passed a string, you will then return a dictionary (object in JavaScript) with as keys the characters, and as values how many times that character is in the string. 
         * You can assume you will be given valid input.
         */
        public static Dictionary<char, int> CharFreq(string message)
        {
            //return message.GroupBy(x => x)
            //    .Select(x => new
            //    {
            //        Key = x.Key,
            //        Count = x.Count()
            //    }).ToDictionary(x => x.Key, x => x.Count);
            return message.GroupBy(c => c).ToDictionary(x => x.Key, x => x.Count());
        }

        /*
         * https://www.codewars.com/kata/557af9418895e44de7000053
         * Create a function that takes a string and an integer (n).
         * The function should return a string that repeats the input string n number of times.
         * If anything other than a string is passed in you should return "Not a string"
         * "Hi", 2 --> "HiHi"
         * 1234, 5 --> "Not a string"
         */
        public static string RepeatString(object toRepeat, int n)
        {
            return toRepeat is string ? string.Concat(Enumerable.Repeat(toRepeat, n)) : "Not a string";
        }

        /*
         * https://www.codewars.com/kata/559ac78160f0be07c200005a
         * Write a function that returns a string in which firstname is swapped with last name.
         * Kata.NameShuffler("john McClane") => "McClane john"
         */
        public static string NameShuffler(string str)
        {
            return string.Join(' ', str.Split(' ').Reverse());
        }

        /*
         * https://www.codewars.com/kata/57cfdf34902f6ba3d300001e
         * You will be given a vector of strings. 
         * You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.
         * The returned value must be a string, and have "***" between each of its letters.
         * You should not remove or add elements from/to the array.
         */
        public static string TwoSort(string[] s)
        {
            return string.Join("***", s.OrderBy(x => x, StringComparer.Ordinal).First().ToArray());
        }

        /*
         * https://www.codewars.com/kata/57613fb1033d766171000d60
         * Finish the uefaEuro2016() function so it return string just like in the examples below:
         * uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
         * uefaEuro2016(['Belgium', 'Italy'],[0, 2]) // "At match Belgium - Italy, Italy won!"
         * uefaEuro2016(['Portugal', 'Iceland'],[1, 1]) // "At match Portugal - Iceland, teams played draw."
         */
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            var result = scores[0] == scores[1]
                ? "teams played draw."
                : $"{teams[scores.ToList().IndexOf(scores.Max())]} won!";

            return $"At match {teams[0]} - {teams[1]}, {result}";
        }
    }
}
