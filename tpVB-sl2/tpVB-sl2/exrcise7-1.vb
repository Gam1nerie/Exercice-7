Module exercise_7_1
    Sub main()

        Dim montant, remise, montantNet As Double

        Console.WriteLine("veuiller taper votre montant")
        montant = Console.ReadLine()
        remise = 0

        If montant > 5000 Then
            remise = 2 / 100
            Console.WriteLine("remise de 2%")

        ElseIf montant >= 2000 Then ' montant compris entre 2000 et 5000
            remise = 1 / 100
            Console.WriteLine("remise de 1%")
        Else
            Console.WriteLine("pas de remise")

        End If

        montantNet = montant * (1 - remise)

        Console.WriteLine("Le montant net est : " + montantNet.ToString())
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module


