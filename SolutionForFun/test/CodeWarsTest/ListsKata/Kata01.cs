using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.ListsKata
{
    partial class Kata
    {
        //Find the mean (average) of a list of numbers in an array.
        public static int FindAverage(int[] nums)
        {
            return (int)nums.Average();
        }

        // https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b
        // In this kata you will create a function that takes in a list and returns a list with the reverse order.
        public static List<int> ReverseList(List<int> list)
        {
            return Enumerable.Reverse(list).ToList();
        }

        // https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad
        // Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.
        public static int[] InvertValues(int[] input)
        {
            return input.Select(x => -x).ToArray();
        }

        // https://www.codewars.com/kata/56f699cd9400f5b7d8000b55
        public static string[] FixTheMeerkat(string[] arr)
        {
            return arr.Reverse().ToArray();
        }

        // https://www.codewars.com/kata/576bb71bbbcf0951d5000044
        // Given an array of integers.
        // Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.
        // If the input array is empty or null, return an empty array.
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[] { };
            }

            var positiveCounter = input.Count(x => x > 0);
            var negativeSum = input.Where(y => y < 0).Sum();
            return new[] { positiveCounter, negativeSum };
        }

        // https://www.codewars.com/kata/56f69d9f9400f508fb000ba7
        // You take your son to the forest to see the monkeys. You know that there are a certain number there (n), but your son is too young to just appreciate the full number, he has to start counting them from 1.
        // As a good parent, you will sit and count with him.Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }

        // https://www.codewars.com/kata/559d2284b5bb6799e9000047
        // What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?
        // Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element.
        // Note: String will have at least one element; words will always be separated by a space.
        public static string[] AddLength(string str)
        {
            return str.Split(" ").Select(x => $"{x} {x.Length}").ToArray();
        }

        // https://www.codewars.com/kata/582e0e592029ea10530009ce
        // The objective of Duck, duck, goose is to walk in a circle, tapping on each player's head until one is chosen.
        // Task: Given an array of Player objects (an array of associative arrays in PHP) and an index (1-based), return the name of the chosen Player(name is a property of Player objects, e.g Player.name)
        public class Player
        {
            public string Name { get; set; }

            public Player(string name)
            {
                this.Name = name;
            }
        }

        public static string DuckDuckGoose(Player[] players, int goose)
        {
            return players[(goose - 1) % players.Length].Name;
        }

        // https://www.codewars.com/kata/5417423f9e2e6c2f040002ae
        // Given a non-negative integer, return an array / a list of the individual digits in order.
        // Examples:
        // 123 => [1,2,3]
        // 1 => [1]
        // 8675309 => [8,6,7,5,3,0,9]
        public static int[] Digitize(int n)
        {
            return n.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
        }

        // https://www.codewars.com/kata/5d49c93d089c6e000ff8428c
        // Your task is to determine how many files of the copy queue you will be able to save into your Hard Disk Drive.
        // The files must be saved in the order they appear in the queue.
        public static int Save(int[] sizes, int hd)
        {
            //var saved = 0;
            //var counter = 0;
            //for (int i = 0; i < sizes.Length; i++)
            //{
            //    if (saved + sizes[i] <= hd)
            //    {
            //        saved += sizes[i];
            //        counter++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //return counter;

            var saved = 0;
            return sizes.TakeWhile(x => (saved += x) <= hd).Count();
        }
    }
}
