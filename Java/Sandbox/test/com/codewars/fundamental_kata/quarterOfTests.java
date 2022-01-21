package com.codewars.fundamental_kata;

import com.CodeWars.FundamentalKata;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.Assertions;
public class quarterOfTests {

    @Test
    public void exampleTests() {
        Assertions.assertEquals(1, FundamentalKata.quarterOf(3));
        Assertions.assertEquals(3, FundamentalKata.quarterOf(8));
        Assertions.assertEquals(4, FundamentalKata.quarterOf(11));
    }
}
