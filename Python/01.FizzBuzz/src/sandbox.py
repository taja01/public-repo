from os import pipe

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

cars = ["Bmw", "Hyundai", "Mazda"]
writeCarsDetails(cars)


print("remove last car")
cars.pop(0)
writeCarsDetails(cars)

print("add new one")
cars.append("Toyota")
writeCarsDetails(cars)