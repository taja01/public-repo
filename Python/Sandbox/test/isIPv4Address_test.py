import unittest
from src.Kata import isIPv4Address

class IsIPv4Address(unittest.TestCase):
    def test1(self):
        self.assertFalse(isIPv4Address("0..1.0.0"))

    def test2(self):
        self.assertFalse(isIPv4Address("7283728"))

    def test3(self):
        self.assertFalse(isIPv4Address("255.255.255.255abcdekjhf"))

    def test4(self):
        self.assertTrue(isIPv4Address("172.16.254.1"))

    def test5(self):
        self.assertFalse(isIPv4Address("172.316.254.1"))

    def test6(self):
        self.assertFalse(isIPv4Address("1"))