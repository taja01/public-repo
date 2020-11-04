package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class AbsoluteValuesSumMinimizationTests {
    @Test
    public void Test1() {
        Assertions.assertEquals(4, Kata.absoluteValuesSumMinimization(new int[] { 2, 4, 7 }));
    }

    @Test
    public void Test2() {
        Assertions.assertEquals(2, Kata.absoluteValuesSumMinimization(new int[] { 2, 3 }));
    }

    @Test
    public void Test3() {
        Assertions.assertEquals(1, Kata.absoluteValuesSumMinimization(new int[] { 1, 1, 3, 4 }));
    }

    @Test
    public void Test4() {
        Assertions.assertEquals(23, Kata.absoluteValuesSumMinimization(new int[] { 23 }));
    }

    @Test
    public void Test5() {
        Assertions.assertEquals(15, Kata.absoluteValuesSumMinimization(new int[] { -10, -10, -10, -10, -10, -9, -9, -9, -8, -8, -7, -6, -5, -4, -3, -2, -1, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }));
    }

    @Test
    public void Test6() {
        Assertions.assertEquals(-4, Kata.absoluteValuesSumMinimization(new int[] { -4, -1 }));
    }

    @Test
    public void Test7() {
        Assertions.assertEquals(7, Kata.absoluteValuesSumMinimization(new int[] { 0, 7, 9 }));
    }

    @Test
    public void Test8() {
        Assertions.assertEquals(0, Kata.absoluteValuesSumMinimization(new int[] { -1000000, -10000, -10000, -1000, -100, -10, -1, 0, 1, 10, 100, 1000, 10000, 100000, 1000000 }));
    }
}
