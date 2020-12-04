import unittest
from src.Kata import firstDigit

class FirstDigitTests(unittest.TestCase):
    def test1(self):
        self.assertEqual('1', firstDigit('var_1__Int'))

    def test2(self):
        self.assertEqual('2', firstDigit('q2q-q'))
    
    def test3(self):
        self.assertEqual('0', firstDigit('0ss'))

    def test4(self):
        self.assertEqual('2', firstDigit('_Aas_23'))

    def test5(self):
        self.assertEqual('9', firstDigit('a a_933'))

    def test6(self):
        self.assertEqual('0', firstDigit('ok0'))