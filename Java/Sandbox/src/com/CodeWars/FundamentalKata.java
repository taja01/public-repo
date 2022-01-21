package com.CodeWars;

public class FundamentalKata {

    /*
     * https://www.codewars.com/kata/5ce9c1000bab0b001134f5af
     * Given a month as an integer from 1 to 12, return to which quarter of the year it belongs as an integer number.
     */
    public static int quarterOf(int month) {
        return (month + 2) / 3;
    }
}
