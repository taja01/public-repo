package com.codesignal;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class DepositProfitTests {
    @Test
    public void Test1() {
        Assertions.assertEquals(3, Kata.depositProfit(100, 20, 170));
    }

    @Test
    public void Test2() {
        Assertions.assertEquals(1, Kata.depositProfit(100, 1, 101));
    }

    @Test
    public void Test3() {
        Assertions.assertEquals(6, Kata.depositProfit(1, 100, 64));
    }

    @Test
    public void Test4() {
        Assertions.assertEquals(6, Kata.depositProfit(20, 20, 50));
    }

    @Test
    public void Test5() {
        Assertions.assertEquals(4, Kata.depositProfit(50, 25, 100));
    }
}
