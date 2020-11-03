package com.codesignal;

public class Kata {
    /*
     * Call two arms equally strong if the heaviest weights they each are able to lift are equal.
     * Call two people equally strong if their strongest arms are equally strong (the strongest arm can be both the right and the left), and so are their weakest arms.
     * Given your and your friend's arms' lifting capabilities find out if you two are equally strong.
     */
   public static boolean areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
       return Math.max(yourLeft, yourRight) == Math.max(friendsLeft, friendsRight)
               && Math.min(yourLeft,yourRight) == Math.min(friendsLeft,friendsRight);
   }

    //Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
    public static int arrayMaximalAdjacentDifference(int[] inputArray) {
        int max = 0;
        for (int i = 1; i < inputArray.length; i++) {
            max = Math.max(max, Math.abs(inputArray[i - 1] - inputArray[i]));
        }
        return max;
   }

    //Check if all digits of the given integer are even.
    public static boolean evenDigitsOnly(int n) {
        return Integer.toString(n).matches("(0|2|4|6|8)*");
    }

    //Correct variable names consist only of English letters, digits and underscores and they can't start with a digit.
    public static  boolean variableName(String name) {
       return name.matches("[a-zA-Z_][a-zA-Z0-9_]*");
    }

    //Given a string, your task is to replace each of its characters by the next one in the English alphabet
    //i.e. replace a with b, replace b with c, etc (z would be replaced by a).
    public static String alphabeticShift(String inputString) {
        char[] c_array = inputString.toCharArray();
        for (int i = 0; i < c_array.length; i++){
            ++c_array[i];
            if (c_array[i] == '{') {
                c_array[i] = 'a';
            }
        }
        return new String(c_array);
    }

    //Given two cells on the standard chess board, determine whether they have the same color or not.
    //For cell1 = "A1" and cell2 = "C3", the output should be chessBoardCellColor(cell1, cell2) = true.
    public static Boolean chessBoardCellColor(String cell1, String cell2) {
       var c1 = cell1.toCharArray();
       var c2 = cell2.toCharArray();

       return (c1[0]+c1[1]) % 2 == (c2[0]+c2[1]) % 2;
    }

    /*
     * Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
     * Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber
     * Example
     * For n = 10 and firstNumber = 2, the output should be circleOfNumbers(n, firstNumber) = 7.
     */
    public static int circleOfNumbers(int n, int firstNumber) {

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
    public static int depositProfit(int deposit, int rate, int threshold)    {
        return (int)Math.ceil(Math.log10((double)threshold / deposit)/Math.log10(1 + (double)rate / 100));
    }
}
