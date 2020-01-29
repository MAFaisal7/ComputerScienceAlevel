Module Module1

    Sub Main()
	'ahmar kashan shehzad
        Dim vehicleid As String = "AAA222AC2"
        Dim lengthcheck As Integer
        Dim x As Integer
        Dim validcheck As Boolean = True

        lengthcheck = Len(vehicleid)
        If lengthcheck > 9 Or lengthcheck < 6 Then
            Console.WriteLine("invalid id")
        Else
            For x = 1 To 3
                If Mid(vehicleid, x, 1) <> UCase(Mid(vehicleid, x, 1)) Then
                    Console.WriteLine("invalid id")
                    x = 3
                    validcheck = False

                End If
            next
            If validcheck Then
                For x = 4 To 5
                    If Not IsNumeric(Mid(vehicleid, x, 1)) Then
                        Console.WriteLine("invalid id")
                        validcheck = False

                    End If
                Next
            End If

            If validcheck Then
                For x = 6 To Len(vehicleid)
                    If Mid(vehicleid, x, 1) <> UCase(Mid(vehicleid, x, 1)) Or IsNumeric(Mid(vehicleid, x, 1)) Then
                        Console.WriteLine("invalid id")
                        x = Len(vehicleid)
                        validcheck = False
                    End If
                Next
            End If

            If validcheck Then
                Console.WriteLine("Valid Id")

            End If

        End If

        Console.ReadKey()

    End Sub

End Module
