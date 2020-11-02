import unittest
from src.Kata import circleOfNumbers

class CircleOfNumbersTests(unittest.TestCase):
    def test1(self):
        self.assertEqual(7, circleOfNumbers(10, 2))

    def test2(self):
        self.assertEqual(2, circleOfNumbers(10, 7))

    def test3(self):
        self.assertEqual(3, circleOfNumbers(4, 1))

    def test4(self):
        self.assertEqual(0, circleOfNumbers(6, 3))
    
    def test5(self):
        self.assertEqual(15, circleOfNumbers(18, 6))

    def test6(self):
        self.assertEqual(4, circleOfNumbers(12, 10))

    def test7(self):
        self.assertEqual(14, circleOfNumbers(18, 5))