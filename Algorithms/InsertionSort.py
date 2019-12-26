# Driver code 
my_list = [56,345,78,23,98,34,65,85]

for i in range(1, len(my_list)):
    
    #The first value after the sorted array 
    key = my_list[i]
    
    # Values that are greater than the key value ...
    # .. move one index forward 
    j = i - 1
    while j>=0 and key<=my_list[j]:
        my_list[j + 1] = my_list[j]
        j -= 1
    
    my_list[j + 1] = key 
    
    
#Prints Array
print("Sorted array:", my_list)