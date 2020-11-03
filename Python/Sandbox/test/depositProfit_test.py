import unittest
from src.Kata import depositProfit

class DepositProfitTest(unittest.TestCase):
    def test1(self):
        self.assertEqual(3, depositProfit(100, 20, 170))

    def test2(self):
        self.assertEqual(1, depositProfit(100, 1, 101))

    def test3(self):
        self.assertEqual(6, depositProfit(1, 100, 64))

    def test4(self):
        self.assertEqual(6, depositProfit(20, 20, 50))

    def test5(self):
        self.assertEqual(4, depositProfit(50, 25, 100))
