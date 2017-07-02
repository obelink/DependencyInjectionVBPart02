Imports DependencyInjectionVBPart02.Interfaces

Public Class Child

    Implements IChild

    Private ReadOnly _drinkService As IDrinkService

    Public Sub New(drinkService As IDrinkService)
        _drinkService = drinkService
    End Sub

    Public Sub Drink() Implements IChild.Drink
        _drinkService.Drink()
    End Sub

End Class
