Module Exercice72
    Sub Main()

        Dim jours As Double
        Dim km As Double
        Dim essence_j As Double
        Dim essence_k As Double
        Dim essence_r As Double
        Dim diesel_j As Double
        Dim diesel_k As Double
        Dim diesel_r As Double

        Console.WriteLine("Nombre de jours de location ?")
        jours = Console.ReadLine()
        Console.WriteLine("Distance à parcourir (en kms) ?")
        km = Console.ReadLine()

        essence_j = jours * 30
        essence_k = km * 0.85
        essence_r = essence_j + essence_k

        diesel_j = jours * 35
        diesel_k = km * 0.65
        diesel_r = diesel_j + diesel_k

        If essence_r < diesel_r Then

            Console.WriteLine("Meilleur choix : Essence")


        End If

        If diesel_r < essence_r Then

            Console.WriteLine("Meilleur choix : Diesel")

        Else

            Console.WriteLine("Meilleur choix : les deux")

        End If


        Console.WriteLine("Au revoir.")
        Console.ReadLine()


    End Sub
End Module
