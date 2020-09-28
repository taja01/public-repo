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