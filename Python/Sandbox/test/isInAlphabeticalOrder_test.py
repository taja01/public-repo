import unittest
from src.Kata import isInAlphabeticalOrder

class IsInAlphabeticalOrderTest(unittest.TestCase):
    def test1(self):
        self.assertTrue(isInAlphabeticalOrder(["a", "b", "c"], 'en-GB'))

    def test2(self):
        self.assertTrue(isInAlphabeticalOrder(["b", "b"], 'en-GB'))

    def test3(self):
        self.assertFalse(isInAlphabeticalOrder(["b", "a"], 'en-GB'))
    
    def test4(self):
        self.assertTrue(isInAlphabeticalOrder(["f", "ζ"], 'el-CY'))

    def test5(self):
        self.assertTrue(isInAlphabeticalOrder(["Esports", "Κρίκετ", "Μπάσκετ", "Πινγκ-Πονγκ", "Τένις", "Χόκεϊ επί πάγου" ], 'el-CY'))
    
