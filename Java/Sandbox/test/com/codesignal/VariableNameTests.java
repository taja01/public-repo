package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class VariableNameTests {
    @Test
    public void TestMethod_False_1() {
        Assertions.assertFalse(Kata.variableName("qq-q"));
    }

    @Test
    public void TestMethod_False_2() {
        Assertions.assertFalse(Kata.variableName("2w2"));
    }

    @Test
    public void TestMethod_False_3() {
        Assertions.assertFalse(Kata.variableName(" variable"));
    }

    @Test
    public void TestMethod_False_4() {
        Assertions.assertFalse(Kata.variableName("va[riable0"));
    }

    @Test
    public void TestMethod_False_5() {
        Assertions.assertFalse(Kata.variableName("0ss"));
    }

    @Test
    public void TestMethod_False_6() {
        Assertions.assertFalse(Kata.variableName("a a_2"));
    }

    @Test
    public void TestMethod_True_1() {
        Assertions.assertTrue(Kata.variableName("var_1__Int"));
    }

    @Test
    public void TestMethod_True_2() {
        Assertions.assertTrue(Kata.variableName("variable0"));
    }

    @Test
    public void TestMethod_True_3() {
        Assertions.assertTrue(Kata.variableName("a"));
    }

    @Test
    public void TestMethod_True_4() {
        Assertions.assertTrue(Kata.variableName("_Aas_23"));
    }

}
