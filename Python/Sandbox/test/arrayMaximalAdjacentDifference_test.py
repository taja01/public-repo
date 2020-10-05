import unittest
from src.Kata import arrayMaximalAdjacentDifference

class ArrayMaximalAdjacentDifferenceTest(unittest.TestCase):
    def test1(self):
       self.assertEqual(3, arrayMaximalAdjacentDifference([2, 4, 1, 0]))
       
    def test2(self):
       self.assertEqual(0, arrayMaximalAdjacentDifference([1, 1, 1, 1]))

    def test3(self):
       self.assertEqual(0, arrayMaximalAdjacentDifference([-2, -2, -2, -2, -2]))

    def test4(self):
       self.assertEqual(4, arrayMaximalAdjacentDifference([-1, 1, -3, -4]))
