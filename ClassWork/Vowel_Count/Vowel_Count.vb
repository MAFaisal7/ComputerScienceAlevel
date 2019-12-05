Module Module1

    Sub Main()
        ' This code outputs the occurrence of a vowels in a string
        Dim instring As String


        Console.Write("Enter any text: ")
        instring = Console.ReadLine()


        VowelCount(instring)

        Console.ReadKey()

    End Sub

    Function VowelCount(ByVal instring As String)

        Dim n, j As Integer
        Dim nchar As Char
        Dim count As Integer = 0
        Dim total As Integer = 0
        Dim vowelLookup(4) As Char
        Dim counting(4) As Integer

        vowelLookup = {"a", "e", "i", "o", "u"}
        counting = {0, 0, 0, 0, 0}

        For n = 1 To Len(instring)
            nchar = Mid(instring, n, 1)

            For j = 0 To 4
                If nchar = vowelLookup(j) Then
                    total = total + 1
                    counting(j) = counting(j) + 1
                End If


            Next

        Next

        j = 0
        For j = 0 To 4
            Console.WriteLine("number of " & vowelLookup(j) & "'s = " & counting(j))
        Next

        Console.WriteLine("total vowels = " & total)


        Return 0


    End Function



End Module
