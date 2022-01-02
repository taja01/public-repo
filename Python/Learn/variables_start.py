f = 0
print(f)

#re-declaring variable
f = "abc"
print(f)

#print(" this is a string " + 123) #Exception has occurred: TypeError can only concatenate str (not "int") to str
print("this is a string " + str(123))


#global vs local variable

def someFunction():
    f = "def variable"
    print(f)

someFunction()
print(f)

#make it global
def newFunction():
    global f
    f = "global warning"
    print(f)

newFunction()
print(f)

del f
print(f) #Exception has occurred: NameError name 'f' is not defined