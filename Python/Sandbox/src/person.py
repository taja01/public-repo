class Person:
    def __init__(self, firstName, lastName):
        self.firstName = firstName
        self.lastName = lastName

    def printDetails(self):
        print(self.firstName, self.lastName)