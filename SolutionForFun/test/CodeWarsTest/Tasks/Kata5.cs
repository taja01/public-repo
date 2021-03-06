﻿namespace CodeWarsTests.Tasks
{
    public partial class Kata
    {

        /*
         * You're given three integers, a, b and c.
         * It is guaranteed that two of these integers are equal to each other.
         * What is the value of the third integer?
         */
        public static int ExtraNumber(int a, int b, int c)
        {
            return a ^ b ^ c;

            //return a == b
            //    ? c
            //    : a == c ? b : a;
        }

        /*
         * Given integers a and b, determine whether the following pseudocode results in an infinite loop
         * while a is not equal to b do
         * increase a by 1
         *  decrease b by 1
         * Assume that the program is executed on a virtual machine which can store arbitrary long numbers and execute forever.
         */
        public static bool IsInfiniteProcess(int a, int b)
        {
            return (a > b || (a + b) % 2 != 0);
        }


        /*
         * Consider an arithmetic expression of the form a#b=c. 
         * Check whether it is possible to replace # with one of the four signs: +, -, * or / to obtain a correct expression.
         */
        public static bool ArithmeticExpression(int a, int b, int c)
        {
            return a + b == c || a - b == c || a * b == c || b * c == a;
        }

    }
}
