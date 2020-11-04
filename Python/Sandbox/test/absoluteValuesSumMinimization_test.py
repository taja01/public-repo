import unittest
from src.Kata import absoluteValuesSumMinimization

class AbsoluteValuesSumMinimizationTests(unittest.TestCase):
    def test1(self):
        self.assertEqual(4, absoluteValuesSumMinimization([2, 4, 7]))

    def test2(self):
        self.assertEqual(2, absoluteValuesSumMinimization([2, 3]))

    def test3(self):
        self.assertEqual(1, absoluteValuesSumMinimization([1, 1, 3, 4]))

    def test4(self):
        self.assertEqual(23, absoluteValuesSumMinimization([23]))

    def test5(self):
        self.assertEqual(15, absoluteValuesSumMinimization([-10, -10, -10, -10, -10, -9, -9, -9, -8, -8, -7, -6, -5, -4, -3, -2, -1, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50]))

    def test6(self):
        self.assertEqual(-4, absoluteValuesSumMinimization([-4, -1]))

    def test7(self):
        self.assertEqual(7, absoluteValuesSumMinimization([0, 7, 9]))

    def test8(self):
        self.assertEqual(0, absoluteValuesSumMinimization([-1000000, -10000, -10000, -1000, -100, -10, -1, 0, 1, 10, 100, 1000, 10000, 100000, 1000000]))