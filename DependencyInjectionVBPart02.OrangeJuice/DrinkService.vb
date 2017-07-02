Imports DependencyInjectionVBPart02.Interfaces

Public Class DrinkService

    Implements IDrinkService

    Public Sub Drink() Implements IDrinkService.Drink
        Console.WriteLine("Drink a glas of orange juice")
    End Sub

End Class
