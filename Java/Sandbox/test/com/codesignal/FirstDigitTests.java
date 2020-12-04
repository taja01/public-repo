package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class FirstDigitTests {
    @Test
    public void Test1() {
        Assertions.assertEquals('1', Kata.firstDigit("var_1__Int"));
    }

    @Test
    public void Test2() {
        Assertions.assertEquals('2', Kata.firstDigit("q2q-q"));
    }

    @Test
    public void Test3() {
        Assertions.assertEquals('0', Kata.firstDigit("0ss"));
    }

    @Test
    public void Test5() {
        Assertions.assertEquals('2', Kata.firstDigit("_Aas_23"));
    }

    @Test
    public void Test6() {
        Assertions.assertEquals('9', Kata.firstDigit("a a_933"));
    }

    @Test
    public void Test7() {
        Assertions.assertEquals('0', Kata.firstDigit("ok0"));
    }
}
