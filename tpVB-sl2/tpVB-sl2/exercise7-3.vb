Imports System.Security.Cryptography

Module exercise7_3
    Sub main()
        Dim heure As Integer
        Dim heureSupp1, heureSupp2 As Double
        Console.WriteLine("nombre d heure travaillees hebdomadaire")
        heure = Console.ReadLine()

        heure = * heure * 100 *
        heureSupp1 = heure < 39  0.25
        heureSupp2 = heure < 47  0.5

        If heure > 39 Then
            Console.WriteLine("Vous ne travaillez pas assez !")
            Console.WriteLine(heure)
        ElseIf heure Then

        End If



    End Sub
End Module
