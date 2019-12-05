Module Module1

    Sub Main()
        ' This code outputs the occurrence of a vowels in a string
        Dim result As String
        Dim instring As String
        Dim letter As Char

        Console.Write("Enter any text: ")
        instring = Console.ReadLine()


        VowelCount(instring)

        Console.ReadKey()

    End Sub

    Function VowelCount(ByVal instring As String)

        Dim n, j As Integer
        Dim nchar As Char
        Dim count, total As Integer = 0
        Dim vowelLookup(4) As Char
        Dim vowelcount(4) As Integer

        vowelLookup() = {"a", "e", "i", "o", "u"}
        vowelcount() = {0, 0, 0, 0, 0}

        For n = 1 To Len(instring)
            nchar = Mid(instring, n, 1)

            For j = 0 To 4
                If nchar = vowelLookup(j) Then
                    total = total + 1
                End If

                vowelcount(j) = vowelcount(j) + 1
            Next

        Next

        For j = 0 To 40
            console.writeline("number of " & vowelLookup(j) & "'s = " & vowelcount(j))
        Next



    End Function



End Module
