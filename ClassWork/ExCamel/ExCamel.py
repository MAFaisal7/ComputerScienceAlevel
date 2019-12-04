# This Code turns this text "MyNameIsShehzad" to "my name is shehzad"
# Function
def ExCamel(InString):
    OutString = ""
    n = 0

    for i in InString:
        if i.isupper():
            if n > 0:
                OutString += " "

        OutString += i.lower()
        n += 1
    return OutString

# Main

# Driver Code
out = ExCamel("MyUserInput")
print(out)
input("Press Enter to Continue: ")  # Readkey
