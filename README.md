# Projeto C# - Design Patterns

Projeto simples em C# para testar e demonstrar diferentes padrões de projeto (Design Patterns).

## � Como Executar

### Via Terminal
```bash
dotnet run --project CSharpProject.csproj
```

### Via Visual Studio Code
1. Pressione `F5` para executar com debug
2. Ou pressione `Ctrl+F5` para executar sem debug
3. Ou use o menu `Run > Run Without Debugging`

## 📁 Estrutura do Projeto

```
design_patterns/
├── Program.cs                                    # Arquivo principal com os testes
├── DesignPatterns/
│   ├── Creational/
│   │   ├── Singleton/                           # Padrão Singleton
│   │   │   ├── Singleton.cs                     # Implementação básica
│   │   │   ├── SingletonLazy.cs                # Implementação Lazy
│   │   │   └── SingletonLogger.cs              # Exemplo prático (Logger)
│   │   └── Factory/                             # Padrão Factory
│   │       ├── Factory.cs                       # Factory básico (Veículos)
│   │       ├── FactoryConnection.cs             # Factory para conexões BD
│   │       └── FactoryInheritance.cs           # Factory com herança
│   ├── Behavioral/                              # (Para futuros padrões)
│   └── Structural/                              # (Para futuros padrões)
└── CSharpProject.csproj                        # Configuração do projeto
```

## 🛠️ Padrões Implementados

### ✅ Criacionais (Creational)
- **Singleton** - Garante uma única instância da classe
  - Implementação básica, Lazy e Logger prático
- **Factory** - Cria objetos sem especificar suas classes concretas
  - Factory básico para criação de veículos
  - Factory para conexões de banco de dados
  - Factory Method com herança para transportes

### 📋 Para Implementar
- **Observer** - Define dependência um-para-muitos entre objetos
- Strategy, Command, State (Behavioral)
- Adapter, Decorator, Facade (Structural)
- Builder, Abstract Factory (Creational)

## � Comandos Úteis

```bash
# Compilar
dotnet build CSharpProject.csproj

# Executar
dotnet run --project CSharpProject.csproj

# Limpar
dotnet clean CSharpProject.csproj
```

## � Como Adicionar Novos Padrões

1. Crie um novo arquivo na pasta apropriada (`Creational/`, `Behavioral/`, `Structural/`)
2. Implemente o padrão seguindo as convenções C#
3. Adicione um método de teste no `Program.cs`
4. Execute o projeto para verificar se funciona

Cada padrão deve ter seu próprio arquivo para facilitar o estudo e manutenção!
