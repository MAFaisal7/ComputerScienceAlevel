# encrypt function
def encrypt(plain, lookup2):
    cypher = ""
    for j in plain:
        cypher = cypher + lookup2[ord(j)]  # ord turns ascii character to its respective value
    return cypher

# decrypt function
def decrypt(cypher,lookup2):
    oldplain = ""

    for k in cypher:
        count = 0
        found = False
        while not found:
            if lookup2[count] == k:
                found = True
            else:
                count += 1
        oldplain = oldplain + chr(count)
    return oldplain

# Populating lookup
lookup = []
for i in range(127):
    a = 0
    a = i - 15
    if a < 0:
        lookup.append(chr(127 + a))
    else:
        lookup.append(chr(a))

# The main program
choice = 0
while choice != 3:
    choice = int(input(
    """#############################
To Encrypt text press 1
To Decrypt text press 2
To exit press 3
############################
Enter Num:"""))
    if choice == 1:
        plain = input("\nEnter the text you want to Encrypt: ")
        cypher = encrypt(plain,lookup)
        print("Plain Text: {} Encrypted Text: {}".format(plain, cypher))
    elif choice == 2:
        cypher = input("\nEnter the text you want to Decrypt: ")
        decypher = decrypt(cypher, lookup)
        print("Cypher Text: {} Decrypted Text: {}".format(cypher, decypher))
