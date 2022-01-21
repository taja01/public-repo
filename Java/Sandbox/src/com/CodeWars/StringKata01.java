package com.CodeWars;

import java.util.Arrays;
import java.util.Collections;

import static java.util.Arrays.sort;

public class StringKata01 {
    /*https://www.codewars.com/kata/5f70c883e10f9e0001c89673*/
    public static int[] flip(char dir, int[] arr) {
        if (dir == 'R'){
            sort(arr);
        }
        else {
            arr =  Arrays.stream(arr)
                    .boxed()
                    .sorted(Collections.reverseOrder())
                    .mapToInt(Integer::intValue)
                    .toArray();
        }
        return arr;
    }
}
