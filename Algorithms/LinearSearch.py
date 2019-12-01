# Linear Search is basically looking into every element of the array and seeing if the required element is
# present or not

names = ["shehzad","kashan","ahmar","ghufran","maulana sahab"]
found = False
length = len(names)
index = 0

name = input("Enter your name: ")

while not found and index < length - 1:
    if names[index] == name:
        found = True
    else:
        index += 1

if found:
    print("You are registered")
else:
    print("Proceed to counter number 1 for more details. ")

input("Press Enter to continue: ")

# This code is done through in function // Alternate code

#name = input("Enter your name: ")
#if name in names:
#    print("You are already registered. ")
#else:
#    print("Proceed to counter number 1 for more details. ")
