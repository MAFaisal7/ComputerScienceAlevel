Module Module1

    Sub Main()

        Dim result As String
        Dim instring As String
        Dim letter As Char

        Console.Write("Enter text: ")
        instring = Console.ReadLine()

        Console.Write("Enter a character to find its occurence: ")
        letter = Console.ReadLine()
        result = Character_Count(letter, instring)

        Console.WriteLine(result)

        Console.ReadKey()

    End Sub

    Function Character_Count(ByVal letter As Char, ByVal instring As String)

        Dim n As Integer
        Dim nchar As Char
        Dim count As Integer = 0

        For n = 1 To Len(instring)
            nchar = Mid(instring, n, 1)
            If nchar = UCase(letter) Or nchar = LCase(letter) Then
                count = count + 1
            End If

        Next

        If count = 0 Then
            Return "Sorry " & letter & " does not exist in the text"
        Else
            Return "Number of " & letter & "'s = " & Str(count)
        End If

    End Function

End Module
