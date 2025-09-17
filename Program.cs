using System;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Projeto de Testes - Design Patterns ===\n");

            // Teste do padrão Singleton básico (thread-safe simples)
            Console.WriteLine("1. Testando Singleton básico (thread-safe simples):");
            TestBasicSingleton();

            Console.WriteLine("\n" + new string('=', 50));

            // Teste do padrão Singleton com Lazy<T>
            Console.WriteLine("2. Testando Singleton com Lazy<T>:");
            TestLazySingleton();

            Console.WriteLine("\n" + new string('=', 50));

            // Teste do padrão Singleton Logger
            Console.WriteLine("3. Testando Singleton Logger:");
            TestLoggerSingleton();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void TestBasicSingleton()
        {
            // Primeira instância
            var instance1 = Singleton.Instance;
            Singleton.ExibirMensagem("Olá, sou um Singleton básico (thread-safe simples)! INSTÂNCIA 1");

            // Segunda instância (deve ser a mesma)
            var instance2 = Singleton.Instance;
            Singleton.ExibirMensagem("Olá, sou um Singleton básico (thread-safe simples)! INSTÂNCIA 2");

            // Verificar se são a mesma instância
            Console.WriteLine($"✅ São a mesma instância? {ReferenceEquals(instance1, instance2)}");
        }

        static void TestLazySingleton()
        {
            // Primeira instância
            var instance1 = SingletonLazy.Instance;
            SingletonLazy.ExibirMensagem("Olá, sou um Singleton com Lazy<T>! INSTÂNCIA 1");

            // Segunda instância (deve ser a mesma)
            var instance2 = SingletonLazy.Instance;
            SingletonLazy.ExibirMensagem("Olá, sou um Singleton com Lazy<T>! INSTÂNCIA 2");

            // Verificar se são a mesma instância
            Console.WriteLine($"✅ São a mesma instância? {ReferenceEquals(instance1, instance2)}");
        }

        static void TestLoggerSingleton()
        {
            // Primeira instância
            var logger = SingletonLogger.Instance;
            logger.Log("Mensagem de log 1");
            logger.Log("Mensagem de log 2");

            // Exibir logs
            logger.ShowLogs();
        }
    }
}
