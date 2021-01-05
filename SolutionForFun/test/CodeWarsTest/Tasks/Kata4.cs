using System;
using System.Linq;

namespace CodeWarsTests.Tasks
{
    public static partial class Kata
    {
        /*
         * Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
         * Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber
         * Example
         * For n = 10 and firstNumber = 2, the output should be circleOfNumbers(n, firstNumber) = 7.
         */
        public static int CircleOfNumbers(int n, int firstNumber)
        {
            return ((n / 2) + firstNumber) % n;
        }

        /*
         * You have deposited a specific amount of money into your bank account. Each year your balance increases at the same growth rate. 
         * With the assumption that you don't make any additional deposits, find out how long it would take for your balance to pass a specific threshold.
         * For deposit = 100, rate = 20, and threshold = 170, the output should be depositProfit(deposit, rate, threshold) = 3.
         * Each year the amount of money in your account increases by 20%. So throughout the years, your balance would be:
         * year 0: 100;
         * year 1: 120;
         * year 2: 144;
         * year 3: 172.8.
         * Thus, it will take 3 years for your balance to pass the threshold, so the answer is 3.
         */
        public static int DepositProfit(int deposit, int rate, int threshold)
        {
            return (int)Math.Ceiling(Math.Log((double)threshold / deposit, 1 + (double)rate / 100));
        }

        /*
         * Given a sorted array of integers a, your task is to determine which element of a is closest to all other values of a.
         * In other words, find the element x in a, which minimizes the following sum:
         * abs(a[0] - x) + abs(a[1] - x) + ... + abs(a[a.length - 1] - x)
         */
        public static int AbsoluteValuesSumMinimization(int[] a)
        {
            return a[(a.Length - 1) / 2];
        }

        //Given array of integers, remove each kth element from it.
        public static int[] ExtractEachKth(int[] inputArray, int k)
        {
            return inputArray
                .Where((e, index) => (index + 1) % k != 0)
                .ToArray();
        }

        // Find the leftmost digit that occurs in a given string.
        // [execution time limit] 3 seconds(cs)

        public static char FirstDigit(string inputString)
        {
            return inputString.First(char.IsDigit);
        }

        /*
         * Some phone usage rate may be described as follows:
         * first minute of a call costs min1 cents,
         * each minute from the 2nd up to 10th (inclusive) costs min2_10 cents
         * each minute after 10th costs min11 cents.
         * 
         * You have s cents on your account before the call.
         * What is the duration of the longest call (in minutes rounded down to the nearest integer) you can have?
         */
        public static int PhoneCall(int min1, int min2_10, int min11, int s)
        {
            if (s < min1)
            {
                return 0;
            }
            s -= min1;

            var min2_10_s = s / min2_10;
            if (min2_10_s <= 9)
            {
                return 1 + min2_10_s;
            }
            s -= min2_10 * 9;

            return s / min11 + 10;
        }
        /*
         * You are playing an RPG game. Currently your experience points (XP) total is equal to experience.
         * To reach the next level your XP should be at least at threshold.
         * If you kill the monster in front of you, you will gain more experience points in the amount of the reward.
         * Given values experience, threshold and reward, check if you reach the next level after killing the monster.
         */
        public static bool ReachNextLevel(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }

        /*
         * You found two items in a treasure chest! 
         * The first item weighs weight1 and is worth value1, and the second item weighs weight2 and is worth value2.
         * What is the total maximum value of the items you can take with you, assuming that your max weight capacity is maxW and you can't come back for the items later?
         * 
         * Note that there are only two items and you can't bring more than one item of each type, i.e. you can't take two first items or two second items.
         */
        public static int KknapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            return weight1 > maxW && weight2 > maxW
                ? 0
                : weight1 + weight2 <= maxW
                ? value1 + value2
                : value1 > value2 ? weight1 <= maxW ? value1 : value2 : weight2 <= maxW ? value2 : value1;
        }

    }
}
