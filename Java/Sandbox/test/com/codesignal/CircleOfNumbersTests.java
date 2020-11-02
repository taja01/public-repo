package com.codesignal;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class CircleOfNumbersTests {
    @Test
    public void Test1() {
        Assertions.assertEquals(7, Kata.circleOfNumbers(10, 2));
    }

    @Test
    public void Test2() {
        Assertions.assertEquals(2, Kata.circleOfNumbers(10, 7));
    }

    @Test
    public void Test3() {
        Assertions.assertEquals(3, Kata.circleOfNumbers(4, 1));
    }

    @Test
    public void Test4() {
        Assertions.assertEquals(0, Kata.circleOfNumbers(6, 3));
    }

    @Test
    public void Test5() {
        Assertions.assertEquals(15, Kata.circleOfNumbers(18, 6));
    }

    @Test
    public void Test6() {
        Assertions.assertEquals(4, Kata.circleOfNumbers(12, 10));
    }

    @Test
    public void Test7() {
        Assertions.assertEquals(14, Kata.circleOfNumbers(18, 5));
    }
}
