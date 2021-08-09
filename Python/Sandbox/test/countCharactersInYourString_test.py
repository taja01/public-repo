import unittest
from src.Kata import count


class CountCharactersInYourStringTest(unittest.TestCase):
    def test_null(self):
        self.assertEqual(count(None), {})

    def test_empty(self):
        self.assertEqual(count(''), {})

    def test_1(self):
        self.assertEqual(count('aba'), {'a': 2, 'b': 1})

    def test_2(self):
        self.assertEqual(count('a'), {'a': 1})