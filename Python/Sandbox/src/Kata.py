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

#Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
def arrayMaximalAdjacentDifference(a):
    return max([abs(a[i]-a[i+ 1]) for i in range(len(a)-1)])

"""
An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. 
There are two versions of the Internet protocol, and thus two versions of addresses. 
One of them is the IPv4 address.
"""
def isIPv4Address(s):
    array = s.split('.')
    return len(array) == 4 and all(x.isdigit() and 0 <= int(x) < 256  for x in array)