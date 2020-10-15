import unittest
from src.Kata import variableName

class VariableNameTest(unittest.TestCase):
    def test1(self):
        self.assertTrue(variableName("var_1__Int"))

    def test2(self):
        self.assertFalse(variableName("qq-q"))

    def test3(self):
        self.assertFalse(variableName("2w2"))

    def test4(self):
        self.assertFalse(variableName(" variable"))

    def test5(self):
        self.assertFalse(variableName("va[riable0"))

    def test6(self):
        self.assertTrue(variableName("variable0"))

    def test7(self):
        self.assertTrue(variableName("a"))

    def test8(self):
        self.assertTrue(variableName("_Aas_23"))

    def test9(self):
        self.assertFalse(variableName("a a_2"))

    def test9(self):
        self.assertFalse(variableName("0ss"))
