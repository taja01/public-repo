import random

class Person:
    __age = random.randint(0,100)
    def __init__(self, firstName, lastName):
        self.firstName = firstName
        self.lastName = lastName
    


    def printDetails(self):
        print("Hello! My name is {0} {1} and I am {2} years old".format(self.firstName, self.lastName, self.__age))