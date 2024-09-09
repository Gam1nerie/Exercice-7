Module ConditionnelleCasGénéral

    Sub Main()

        Dim noteLue As Integer

        Console.WriteLine("Saisir une note ?")

        noteLue = Console.ReadLine()

        If noteLue > 10 Then

            Console.WriteLine("Note au-dessus de la moyenne.")

        Else

            Console.WriteLine("Note au-dessous de la moyenne.")

        End If

    End Sub

End Module
