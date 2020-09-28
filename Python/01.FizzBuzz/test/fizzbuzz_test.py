import unittest
from src.Kata import fizzBuzz

class TestFizzBuzz(unittest.TestCase):
    def test_returns1With1PassedIn(self):
        retVal = fizzBuzz(1)
        self.assertEqual("1", retVal)

    def test_returns1With2PassedIn(self):
        retVal = fizzBuzz(2)
        self.assertEqual("2", retVal)

    def test_returnsFizzWith3PassedIn(self):
        retVal = fizzBuzz(3)
        self.assertEqual("Fizz", retVal)

    def test_returnsBuzzWith5PassedIn(self):
        retVal = fizzBuzz(5)
        self.assertEqual("Buzz", retVal)

    def test_returnsFizzWith6PassedIn(self):
        retVal = fizzBuzz(6)
        self.assertEqual("Fizz", retVal)


    def test_returnsBuzzWith10PassedIn(self):
        retVal = fizzBuzz(10)
        self.assertEqual("Buzz", retVal)

    def test_returnsFizzBuzzWith15PassedIn(self):
        retVal = fizzBuzz(10)
        self.assertEqual("Buzz", retVal)