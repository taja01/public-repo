package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class EvenDigitsOnlyTests {
    @Test
    public void test1(){
        Assertions.assertFalse(Kata.evenDigitsOnly(1));
    }

    @Test
    public void test2(){
        Assertions.assertTrue(Kata.evenDigitsOnly(248622));
    }

    @Test
    public void test3(){
        Assertions.assertFalse(Kata.evenDigitsOnly(642386));
    }

    @Test
    public void test4(){
        Assertions.assertTrue(Kata.evenDigitsOnly(248842));
    }
}
