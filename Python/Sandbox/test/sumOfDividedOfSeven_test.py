import unittest
from src.Kata import sumOfDividedOfSeven

class amlatest(unittest.TestCase):
    def test0(self):
        self.assertEqual(sumOfDividedOfSeven({1, 2, 3, 4, 5, 6, 8}), 0)

    def test1(self):
        self.assertEqual(sumOfDividedOfSeven({1, 2, 3,4, 5, 6, 7}), 7)

    def test2(self):
        self.assertEqual(sumOfDividedOfSeven({7, 14, 21}), 42)