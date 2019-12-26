Module Module1

    Sub Main()

        Dim key As Integer
        Dim my_list() As Integer
        Dim j As Integer
        Dim L As Integer

        'Driver Code
        my_list = {9, 8, 7, 6, 5, 4, 3, 2, 1}


        L = my_list.Length


        For i = 1 To L - 1
            key = my_list(i)

            j = i - 1

            While j >= 0 AndAlso key < my_list(j)
                my_list(j + 1) = my_list(j)
                j = j - 1
            End While

            my_list(j + 1) = key
        Next


        For i = 0 To L - 1
            Console.WriteLine("Sorted Array Elenent(" & Str(i) & ") = " & Str(my_list(i)))
        Next

        Console.ReadKey()

    End Sub

End Module