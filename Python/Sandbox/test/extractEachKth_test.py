import unittest
from src.Kata import extractEachKth

class ExtractEachKthTets(unittest.TestCase):
    def test1(self):
        self.assertEqual([1, 2, 4, 5, 7, 8, 10], extractEachKth([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 3))

    def test2(self):
        self.assertEqual([], extractEachKth([1, 1, 1, 1, 1], 1))

    def test3(self):
        self.assertEqual([1, 1, 1, 1], extractEachKth([1, 2, 1, 2, 1, 2, 1, 2], 2))

    def test4(self):
        self.assertEqual([1, 2, 1, 2, 1, 2, 1, 2], extractEachKth([1, 2, 1, 2, 1, 2, 1, 2], 10))

    def test5(self):
        self.assertEqual([2, 6, 10], extractEachKth([2, 4, 6, 8, 10], 2))