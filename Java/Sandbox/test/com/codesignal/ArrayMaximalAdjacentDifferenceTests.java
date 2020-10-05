package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class ArrayMaximalAdjacentDifferenceTests {
    @Test
    public void test1(){
        Assertions.assertEquals(30, Kata.arrayMaximalAdjacentDifference(new int[]{-14, 15, -15}));
    }

    @Test
    public void test2(){
        Assertions.assertEquals(4, Kata.arrayMaximalAdjacentDifference(new int[]{-1, 1, -3, -4}));
    }

    @Test
    public void test3(){
        Assertions.assertEquals(0, Kata.arrayMaximalAdjacentDifference(new int[]{-2, -2, -2, -2, -2}));
    }
}
