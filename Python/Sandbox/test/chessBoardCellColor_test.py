import unittest
from src.Kata import chessBoardCellColor

class ChessBoardCellColorTests(unittest.TestCase):
    def test1(self):
        self.assertTrue(chessBoardCellColor("A1", "C3"))

    def test2(self):
        self.assertFalse(chessBoardCellColor("A1", "A2"))
    
    def test3(self):
        self.assertTrue(chessBoardCellColor("A1", "A3"))
    
    def test4(self):
        self.assertFalse(chessBoardCellColor("A1", "H3"))