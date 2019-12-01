Module Module1

    Sub Main()

        Dim names(4) As String
        Dim found As Boolean = False
        Dim index As Integer = 0
        Dim length As Integer
        Dim name As String


        names = {"shehzad", "kashan", "ahmar", "ghufran"}
        length = names.Length 'Len() doesnt work on arrays for some reasons


        Console.WriteLine("Please enter your name: ")
        name = Console.ReadLine()


        While found = False And index < length - 1
            If names(index) = name Then
                found = True
            Else
                index = index + 1
            End If
        End While

        If found Then
            Console.WriteLine("You are already registered")
        Else
            Console.WriteLine("Proceed to counter 1 for more details")
        End If

        Console.ReadKey()

    End Sub

End Module
