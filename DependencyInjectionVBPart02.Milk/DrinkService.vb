Imports DependencyInjectionVBPart02.Interfaces

Public Class DrinkService

    Implements IDrinkService

    Public Sub Drink() Implements IDrinkService.Drink
        Console.WriteLine("Drink a cup of milk")
    End Sub

End Class
