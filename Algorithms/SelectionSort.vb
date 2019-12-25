Module Module1

    Sub Main()
        Dim min_index, list_length, temp As Integer
        Dim my_list() As Integer

        'Driver Code
        my_list = {1, 0, 2, 7, 4, 3, 5, 6, 9, 8, 12, 54, 98, 909, 234, 87, 234, 89}

        'Length of the array
        list_length = my_list.Length


        For i = 0 To list_length - 1

            min_index = i

            For j = i + 1 To list_length - 1

                If my_list(min_index) > my_list(j) Then
                    min_index = j
                End If

            Next

            temp = my_list(i)
            my_list(i) = my_list(min_index)
            my_list(min_index) = temp

        Next

        For i = 0 To list_length - 1

            Console.WriteLine("my_list(" & Str(i) & ") = " & Str(my_list(i)))

        Next

        Console.ReadKey()

    End Sub

End Module
