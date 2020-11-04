﻿using System;

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

    }
}