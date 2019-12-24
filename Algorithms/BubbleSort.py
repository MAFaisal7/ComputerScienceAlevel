# bubble sort function
def bubble_sort(my_list):
    length = len(my_list)
    
    # goes through all array elements
    for i in range(length):
        # initilizes the swapped to false 
        swapped = False 
        
        # -1 is done because array starts from 0 and we have used the length of list which is always 1 unit greater 
        # - i is done to make to code efficient as the last element of the array will be always sorted after one loop..
        # .. so we dont access it again
        # remember the for loop in python is lower bound inclusive, upper bound exclusive
        for j in range(length - i - 1):
            
            # if the number in current index is greater than the number in the index after that..
            # ..swap them so that greater number goes forward(right)
            if my_list[j] > my_list[j + 1]:
                my_list[j], my_list[j + 1] = my_list[j + 1], my_list[j]
                
                # if swap happens, this will become true
                swapped = True
                
        # if the swap did not happen. swapped will remain false hence the list/array is sorted
        # which means we dont need to loop through the array again ( this makes the algorithm efficient)
        if swapped == False:
            break
        
        
# Driver Code
my_list = [9,8,74,4,5,24,3,9,10,0,3]

# main program          
bubble_sort(my_list)
print("The Sorted array is: ", my_list)


"""
In Python lists are transfered to a function or copied to a variable as reference
so you don't need create another list and append the values into it
"""        