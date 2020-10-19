import unittest
from src.Kata import alphabeticShift

class AlphabeticShiftTest(unittest.TestCase):
    def test1(self):
        self.assertEqual("a", alphabeticShift('z'))

    def test2(self):
        self.assertEqual("dsbaz", alphabeticShift('crazy'))

    def test3(self):
        self.assertEqual("bbbbcccdde", alphabeticShift('aaaabbbccd'))

    def test4(self):
        self.assertEqual("gvaaz", alphabeticShift('fuzzy'))