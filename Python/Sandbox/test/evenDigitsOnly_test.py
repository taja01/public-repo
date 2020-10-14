import unittest
from src.Kata import evenDigitsOnly

class EventDigitsOnlyTests(unittest.TestCase):
    def test1(self):
        self.assertFalse(evenDigitsOnly(1))

    def test2(self):
        self.assertTrue(evenDigitsOnly(248842))

    def test3(self):
        self.assertTrue(evenDigitsOnly(8))

    def test4(self):
        self.assertFalse(evenDigitsOnly(2462487))
