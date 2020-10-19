package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class AlphabeticShiftTests {
    @Test
    public void Test1() {
        Assertions.assertEquals("a", Kata.alphabeticShift("z"));
    }

    @Test
    public void Test2(){
        Assertions.assertEquals("dsbaz", Kata.alphabeticShift("crazy"));
    }

    @Test
    public void Test3() {
        Assertions.assertEquals("bbbbcccdde", Kata.alphabeticShift("aaaabbbccd"));
    }

    @Test
    public void Test4() {
        Assertions.assertEquals("gvaaz", Kata.alphabeticShift("fuzzy"));
    }
}
