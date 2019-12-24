Module Module1

    Sub Main()
        Dim swapped As Boolean
        Dim unsorted() As Integer
        Dim l, temp As Integer

        'Driver Code
        unsorted = {9, 94, 934, 3, 12, 7, 1, 88, 65, 4}
        l = unsorted.Length


        For i = 0 To l
            swapped = False

            ' -2 because in vb the for loop is lower bound to upper bound inclusive unlike python
            For j = 0 To (l - i - 2)

                If unsorted(j) > unsorted(j + 1) Then
                    temp = unsorted(j)
                    unsorted(j) = unsorted(j + 1)
                    unsorted(j + 1) = temp

                    swapped = True
                End If

            Next

            If swapped = False Then
                ' this is like break, if the array is sorted, the loop is ended to make 
                'code efficient
                i = l
            End If
        Next

        For i = 0 To l - 1
            Console.Write(Str(unsorted(i)) & " ")

        Next

        Console.ReadKey()

    End Sub

End Module
