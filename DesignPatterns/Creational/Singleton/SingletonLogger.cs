using System;

namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Implementação do padrão Singleton (Logger)
/// Garante que uma classe tenha apenas uma instância
/// </summary>
public sealed class SingletonLogger
{
    private static readonly SingletonLogger _instance = new SingletonLogger();
    private List<string> _logs = new List<string>();

    private SingletonLogger() { }

    public static SingletonLogger Instance => _instance;

    public void Log(string message)
    {
        _logs.Add($"{DateTime.Now}: {message}");
    }

    public void ShowLogs()
    {
        foreach (var log in _logs)
        {
            Console.WriteLine(log);
        }
    }
}