using System;

namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Implementação do padrão Singleton (Lazy)
/// Garante que uma classe tenha apenas uma instância
/// </summary>
public sealed class SingletonLazy
{
    // Lazy garante criação tardia e thread-safety
    private static readonly Lazy<SingletonLazy> _instance =
        new Lazy<SingletonLazy>(() => new SingletonLazy());

    private SingletonLazy()
    {
        Console.WriteLine("Instância criada com Lazy!");
    }

    public static SingletonLazy Instance => _instance.Value;

    public static void ExibirMensagem(string? message = null)
    {
        Console.WriteLine(message);
    }
}

