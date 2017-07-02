Imports Autofac
Imports Autofac.Core
Imports Autofac.Configuration
Imports DependencyInjectionVBPart02.Interfaces
Imports Microsoft.Extensions.Configuration


Module MainModule

    Private _container As Container

    'Private Sub InitializeContainer()

    '    Dim builder As New ContainerBuilder()

    '    builder.RegisterType(Of Milk.DrinkService).As(Of IDrinkService)()
    '    builder.RegisterType(Of Child).As(Of IChild)()

    '    _container = builder.Build()

    'End Sub

    Private Sub InitializeContainer()

        Dim configurationBuilder = New ConfigurationBuilder()
        configurationBuilder.SetBasePath(Environment.CurrentDirectory)
        configurationBuilder.AddJsonFile("Autofac.json")

        Dim configurationModule As New ConfigurationModule(configurationBuilder.Build())

        Dim containerBuilder = New ContainerBuilder()
        containerBuilder.RegisterModule(configurationModule)

        _container = containerBuilder.Build()

    End Sub

    Sub Main()

        InitializeContainer()

        'Dim drinkService = _container.Resolve(Of IDrinkService)
        'Dim child As New Child(drinkService)
        Dim child = _container.Resolve(Of IChild)
        child.Drink()

        Console.ReadLine()

    End Sub


End Module
