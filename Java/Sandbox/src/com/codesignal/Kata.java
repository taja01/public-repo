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

    public static  boolean variableName(String name) {
       return name.matches("[a-zA-Z_][a-zA-Z0-9_]*");
    }

}
