Module Module1
    Dim compare As Integer
    Dim hello As String = ""
    Sub Main()
        Dim picture(8, 8) As Integer
        picture = {{240, 10, 10, 10, 10, 10, 10, 240},
            {80, 80, 240, 80, 80, 240, 80, 80},
            {80, 80, 240, 80, 80, 240, 80, 80},
            {80, 80, 150, 150, 150, 150, 80, 80},
            {80, 80, 240, 240, 240, 240, 80, 80},
            {80, 80, 240, 80, 80, 240, 80, 80},
            {240, 240, 150, 150, 150, 150, 240, 240},
            {240, 240, 150, 150, 150, 150, 240, 240}}
        compare = 234
        clip(picture)
        For x = 0 To 7
            Console.WriteLine(hello)
            hello = ""
            For y = 0 To 7
                hello = hello + " " + Str(picture(x, y))
            Next
        Next

        Console.ReadKey()
    End Sub
    Sub clip(ByRef picture)
        For y = 0 To 7
            For x = 0 To 7
                If picture(x, y) > compare Then
                    picture(x, y) = compare
                End If
            Next
        Next
    End Sub
End Module
