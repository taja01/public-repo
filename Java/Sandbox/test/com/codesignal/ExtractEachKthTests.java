package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class ExtractEachKthTests {
    @Test
    public void Test1() {
        Assertions.assertArrayEquals(new int[] { 1, 2, 4, 5, 7, 8, 10 }, Kata.extractEachKth(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3));
    }

    @Test
    public void Test2() {
        Assertions.assertArrayEquals(new int[] { }, Kata.extractEachKth(new int[] { 1, 1, 1, 1, 1 }, 1));
    }

    @Test
    public void Test3() {
        Assertions.assertArrayEquals(new int[] { 1, 1, 1, 1 }, Kata.extractEachKth(new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 2));
    }

    @Test
    public void Test4() {
        Assertions.assertArrayEquals(new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, Kata.extractEachKth(new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 10));
    }

    @Test
    public void Test5() {
        Assertions.assertArrayEquals(new int[] { 2, 6, 10 }, Kata.extractEachKth(new int[] { 2, 4, 6, 8, 10 }, 2));
    }
}
