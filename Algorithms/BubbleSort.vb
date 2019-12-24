Module Module1

    Sub Main()
        Dim swapped As Boolean
        Dim unsorted() As Integer
        Dim l, temp As Integer

        'Driver Code
        unsorted = {56, 345, 65, 32, 7, 6, 23, 65, 12, 6}

        l = unsorted.Length 'Length of the array

        For i = 0 To l
            swapped = False 'initilizes the swapped to false

            '- i is done to make to code efficient as the last element of the array will be always sorted after one loop..
            'why -2?:
            '-1 is done because array starts from 0 and we have used the length of list which is always 1 unit greater 
            'another -1 is done as in vb for loop is lower bound inclusive to upper bound inclusive unlike python where..
            '.. it is lower bound inclusive to upper bound exclusive
            For j = 0 To (l - i - 2)

                'if the number in current index is greater than the number in the index after that..
                'swap them so that greater number goes forward(right)
                If unsorted(j) > unsorted(j + 1) Then
                    temp = unsorted(j)
                    unsorted(j) = unsorted(j + 1)
                    unsorted(j + 1) = temp

                    swapped = True
                End If

            Next

            'if the swap did not happen. swapped will remain false hence the list/array is sorted
            'which means we dont need to loop through the array again ( this makes the algorithm efficient)
            If swapped = False Then
                i = l ' this is like break, if the array is sorted, the loop is ended to make the code efficient
            End If
        Next

        Console.Write("Sorted Array: ")
        'Prints the sorted array
        For i = 0 To l - 1
            Console.Write(Str(unsorted(i)) & " ")

        Next

        Console.ReadKey()

    End Sub

End Module