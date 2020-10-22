package com.codesignal;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class ChessBoardCellColorTests {
    @Test
    public void Test1()
    {
        Assertions.assertTrue(Kata.chessBoardCellColor("A1", "C3"));
    }

    @Test
    public void Test2()
    {
        Assertions.assertFalse(Kata.chessBoardCellColor("A1", "A2"));
    }

    @Test
    public void Test3()
    {
        Assertions.assertTrue(Kata.chessBoardCellColor("A1", "A3"));
    }

    @Test
    public void Test4()
    {
        Assertions.assertFalse(Kata.chessBoardCellColor("A1", "H3"));
    }
}
