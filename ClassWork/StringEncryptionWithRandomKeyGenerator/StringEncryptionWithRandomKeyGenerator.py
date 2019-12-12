import random  # imports library named random


# encrypt function
def encrypt(plain, lookup2):
    cypher = ""
    for j in plain:
        cypher = cypher + lookup2[ord(j)]  # ord turns ascii character to its respective value
    return cypher


# decrypt function
def decrypt(cypher, lookup2):
    oldplain = ""

    for k in cypher:
        count = 0
        found = False
        while not found:  # While true
            if lookup2[count] == k:
                found = True
            else:
                count += 1
        oldplain = oldplain + chr(count)
    return oldplain


# Populating key array with random ascii characters
key = [chr(m) for m in range(128)]  # Read list comprehension to understand the declaration of array/list key
                                    # generates array of length 128 with numbers from 0 - 127 e.g [0,1,2,3,4,....,127]
                                    # but chr() function turns the numbers into their respective ascii characters
                                    # example [...,97,98,99,...] --> [...,a,b,c,...]

random.shuffle(key)  # shuffles the array key e.g [...,a,b,c,d,...] --> [f,/,g,a....]


# The main program
choice = 0
while choice != 3:
    choice = int(input("Press 1 to encrypt, Press 2 to Decrypt and Press 3 to exit:\n"))
    if choice == 1:
        plain = input("Enter the text you want to Encrypt:\n")
        cypher = encrypt(plain, key)
        print("Plain Text: {} Encrypted Text: {}".format(plain, cypher))
    elif choice == 2:
        cypher = input("Enter the text you want to Decrypt:\n")
        decypher = decrypt(cypher, key)
        print("Cypher Text: {} Decrypted Text: {}".format(cypher, decypher))

