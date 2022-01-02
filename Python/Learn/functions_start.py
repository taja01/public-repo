def func():
    print("I am a function")

func()
print(func())
print(func)
"""
I am a function
I am a function
None
<function func at 0x0000021314F18820>
"""

def func2(arg1, arg2):
    print(arg1, " ", arg2)

def cube(x):
    return x*x*x 

print(cube(4))

func2("amla", "korte")
func2(10, 20)

def power(num, x=1):
    result = 1
    for i in range(x):
        result = result * num
    return result

print(power(2))
print(power(2,3))

print(power(x=3, num=2))

def multi_add(*args):
    result = 0
    for x in args:
        result = result + x
    return result

print(multi_add(1,2,3,4,5))