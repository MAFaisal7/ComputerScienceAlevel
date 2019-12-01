import pprint

# Driver code
l = 4
w = 3
h = 2

# Setting Dimenstions of a python 3D array
def list_dim(l,w,h):
    my_array = [[['a' for m in range(l)] for i in range(w)] for k in range(h)]  # read list comprehensions
    return my_array 

array_3d  = list_dim(l,w,h).copy()

# populating array
i = 0
m = 0
k = 0
for i in range(h):
    array_3d[i][m][k] = i
    for m in range(w):
        array_3d[i][m][k] = m
        for k in range(l):
            array_3d[i][m][k] = k

pprint.pprint(array_3d)  # displays array in proper format
