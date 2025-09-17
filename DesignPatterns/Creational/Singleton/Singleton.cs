using System;

namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Implementação simples do padrão Singleton
/// Garante que uma classe tenha apenas uma instância
/// </summary>
public sealed class Singleton
{
    private static Singleton? _instance = null;
    private static readonly object _lock = new object();

    // Construtor privado impede instanciação externa
    private Singleton()
    {
        Console.WriteLine("Instância criada!");
    }

    public static Singleton Instance
    {
        get
        {
            lock (_lock) // garante segurança em ambientes multithread
            {
                _instance ??= new Singleton();
                return _instance;
            }
        }
    }

    public static void ExibirMensagem(string? message = null)
    {
        Console.WriteLine(message);
    }
}
