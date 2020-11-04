from person import Person

def writeCarsDetails(array):
    print("*" * 10)
    for c in array:
        print(c)
    print("Number of cars: " + str(len(cars)))
    print("*" * 10)

print("Hello world")
print("*" * 10)

i = 5
print(i)
i = 5.55
print(i)
i = "a"
print(i)

# arrays:
cars = ["Bmw", "Hyundai", "Mazda"]
writeCarsDetails(cars)


print("remove last car")
cars.pop()
writeCarsDetails(cars)

print("add new one")
cars.append("Toyota")
writeCarsDetails(cars)

# list
thislist = ["apple", "banana", "cherry"]

# tuple
thistuple = ("apple", "banana", "cherry")

# set
fruits = {"apple", "banana", "cherry", "mango"}
more_fruits = ["orange", "mango", "grapes"]
fruits.update(more_fruits)
for f in fruits:
    print(f)

#classes:
print("classes:")

p1 = Person("Thomas", "PythonLearner")
p1.printDetails()

print('*'* 10)

print(ord('a')) #97
print(ord('1')) #49

cell1 = "A1"
a = (ord(cell1[0]) + ord(cell1[1]))
print(a)

from Kata import chessBoardCellColor
print(chessBoardCellColor("A1", "A3"))

a = [1,2,3]
print(a)
print(len(a))
print(a[1])

l = len(a)

print(a[l - 1])

print(l / 2)
print(int(l / 2))