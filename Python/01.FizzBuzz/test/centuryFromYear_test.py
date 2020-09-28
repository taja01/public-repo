import unittest
from src.Kata import centuryFromYear

class CenturyFromYearTest(unittest.TestCase):
    def test1(self):
        self.assertEqual(20, centuryFromYear(1905))
    
    def test2(self):
        self.assertEqual(17, centuryFromYear(1700))

    def test3(self):
        self.assertEqual(20, centuryFromYear(1988))
    
    def test4(self):
        self.assertEqual(20, centuryFromYear(2000))

    def test5(self):
        self.assertEqual(21, centuryFromYear(2001))

    def test5(self):
        self.assertEqual(2, centuryFromYear(200))