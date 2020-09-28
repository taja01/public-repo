import unittest
from src.Kata import add
class AddTest(unittest.TestCase):
    def test_1_1(self):
        self.assertEqual(2, add(1, 1))

    def test_2_1(self):
        self.assertEqual(3, add(2, 1))