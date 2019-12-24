# Driver Code
my_list = [923,6,234,56,3,0,123,5,7,3]

# length of the list
length = len(my_list)


for i in range(length):
    
    # index of the element we consider to have the least value
    min_index = i
    
    # i + 1 beacuse i th index is the one we are comparing
    for j in range(i + 1, length):
        
        # if the value at index(currently having the min value) is greater than the value..
        # ..present at another index in the same array/list 
        # then the min_index is changed to the index having smaller value
        if my_list[min_index] > my_list[j]:
            min_index = j
        
    # after one complete loop, the index having smallest value is identified (ignoring the smallest values which have been sorted before)
    # this smallest value is replaced by the index we considered to be smallest ( refer to line 11 : min_index = i)
    my_list[i], my_list[min_index] = my_list[min_index], my_list[i]
    
print("Sorted Array: ", my_list)