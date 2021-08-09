# For multiples of three return "Fizz" instead of the number and for the multiples of five return "Buzz".
# For numbers which are multiples of both three and five return "FizzBuzz".
def fizzBuzz(value):
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


# Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
def arrayMaximalAdjacentDifference(a):
    return max([abs(a[i] - a[i + 1]) for i in range(len(a) - 1)])


"""
An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. 
There are two versions of the Internet protocol, and thus two versions of addresses. 
One of them is the IPv4 address.
"""


def isIPv4Address(s):
    array = s.split('.')
    return len(array) == 4 and all(x.isdigit() and 0 <= int(x) < 256 for x in array)


# Check if all digits of the given integer are even.
def evenDigitsOnly(n):
    return all(int(x) % 2 == 0 for x in str(n))


# Correct variable names consist only of English letters, digits and underscores and they can't start with a digit.
def variableName(name):
    return name.isidentifier()


# Given a string, your task is to replace each of its characters by the next one in the English alphabet
# i.e. replace a with b, replace b with c, etc (z would be replaced by a).
def alphabeticShift(inputString):
    return ''.join((chr(ord(c) + 1) if c != 'z' else 'a' for c in inputString))


def chessBoardCellColor(cell1, cell2):
    return (ord(cell1[0]) + ord(cell1[1])) % 2 == (ord(cell2[0]) + ord(cell2[1])) % 2


# Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any
# two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too). Given n and firstNumber,
# find the number which is written in the radially opposite position to firstNumber Example For n = 10 and
# firstNumber = 2, the output should be circleOfNumbers(n, firstNumber) = 7.
def circleOfNumbers(n, firstNumber):
    return ((n / 2) + firstNumber) % n


# You have deposited a specific amount of money into your bank account. Each year your balance increases at the same
# growth rate. With the assumption that you don't make any additional deposits, find out how long it would take for
# your balance to pass a specific threshold. For deposit = 100, rate = 20, and threshold = 170, the output should be
# depositProfit(deposit, rate, threshold) = 3. Each year the amount of money in your account increases by 20%. So
# throughout the years, your balance would be: year 0: 100; year 1: 120; year 2: 144; year 3: 172.8. Thus,
# it will take 3 years for your balance to pass the threshold, so the answer is 3.
import math


def depositProfit(deposit, rate, threshold):
    return math.ceil(math.log(threshold / deposit, 1 + rate / 100))


# Given a sorted array of integers a, your task is to determine which element of a is closest to all other values of a.
# In other words, find the element x in a, which minimizes the following sum: []
# abs(a[0] - x) + abs(a[1] - x) + ... + abs(a[a.length - 1] - x) 
def absoluteValuesSumMinimization(a):
    return a[int((len(a) - 1) / 2)]


# Given array of integers, remove each kth element from it.
def extractEachKth(inputArray, k):
    return [i for (e, i) in enumerate(inputArray) if (e + 1) % k]


# Find the leftmost digit that occurs in a given string.
def firstDigit(inputString):
    for i in inputString:
        if i.isdigit():
            return i


# The main idea is to count all the occurring characters in a string.
# If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
# What if the string is empty? Then the result should be empty object literal, {}.
from collections import Counter


def count(string):
    return Counter(string)
