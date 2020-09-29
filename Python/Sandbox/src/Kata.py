# For multiples of three return "Fizz" instead of the number and for the multiples of five return "Buzz".
# For numbers which are multiples of both three and five return "FizzBuzz".
def fizzBuzz( value ):
    if value % 15 == 0:
        return "FizzBuzz"
    elif value % 3 == 0:
        return "Fizz"
    elif value % 5 == 0:
        return "Buzz"
    return str(value)

# Write a function that returns the sum of two numbers.
def add(param1, param2):
    return param1 + param2

"""
Given a year, return the century it is in. 
The first century spans from the year 1 up to and including the year 100, the second -
from the year 101 up to and including the year 200, etc.
"""
def centuryFromYear(year):
    return (year + 99) // 100

import locale

def isInAlphabeticalOrder(list, marketCode):
    locale.setlocale(locale.LC_ALL, marketCode)
    current = list[0]
    for next in list[1:]:
        if locale.strcoll(current, next) == 1:
            return False
        current = next
        
    return True
