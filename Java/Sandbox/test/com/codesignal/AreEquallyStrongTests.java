package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class AreEquallyStrongTests {

    @Test
    void test1(){
        Assertions.assertTrue(Kata.areEquallyStrong(10,5,5,10));
    }

    @Test
    void test2(){
        Assertions.assertTrue(Kata.areEquallyStrong(15,10,15,10));
    }

    @Test
    void test3(){
        Assertions.assertFalse(Kata.areEquallyStrong(15,10,15,9));
    }
}