Module Module1

    Sub Main()
        Dim Out As String
        '9608/22/M/J/17 page 93 of p2 booklet
        'Converts this text "MyNameIsShehzad" to "my name is shehzad":

        'Driver Code
        Out = ExCamel("MyUserInput")

        Console.WriteLine(Out)
        Console.ReadKey()

    End Sub

    Function ExCamel(ByVal InString As String)
        Dim NextChar As Char
        Dim OutString As String
        Dim n As Integer

        OutString = ""

        For n = 1 To Len(InString)
            NextChar = Mid(InString, n, 1)
            If NextChar = UCase(NextChar) Then

                If n > 1 Then
                    OutString = OutString & " "
                End If

                NextChar = LCase(NextChar)
            End If
            OutString = OutString & NextChar

        Next

        Return OutString
    End Function

End Module
