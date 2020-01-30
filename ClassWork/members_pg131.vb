Module Module1

    Sub Main()
        Dim membershipnum As Integer = 0
        Dim result As String
        membershipnum = getnum()
        result = OutputLowestScore(membershipnum)

        Console.WriteLine(result)
        Console.ReadKey()


    End Sub

    Function getnum()
        Dim membershipnum As Integer = 0
        Console.WriteLine("Enter your membership number")
        membershipnum = Console.ReadLine
        Do While membershipnum < 1111 Or membershipnum > 9999
            Console.WriteLine("invalid membership number reenter")
            membershipnum = Console.ReadLine

        Loop
        Return membershipnum
    End Function

    Function OutputLowestScore(ByVal membershipnum)
        Dim temp As String = "000000"
        Dim minvalue As String
        Dim memberdata As String = ""

        FileOpen(1, My.Application.Info.DirectoryPath & "/scoredetails.txt", OpenMode.Input)

        minvalue = "999"
        While Not EOF(1)
            Input(1, temp)
            If Left(temp, 4) = membershipnum Then
                If Right(temp, 2) < minvalue Then
                    minvalue = Right(temp, 2)
                    memberdata = temp
                End If
            End If
        End While
        FileClose(1)

        Return "The lowest score was " & minvalue & " on " & Mid(memberdata, 5, 6)
    End Function
End Module
