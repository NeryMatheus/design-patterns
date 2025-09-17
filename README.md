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
├── Program.cs                           # Arquivo principal com os testes
├── DesignPatterns/
│   ├── Creational/
│   │   ├── Singleton.cs                 # Padrão Singleton
│   │   └── Factory.cs                   # Padrão Factory
│   ├── Behavioral/
│   │   └── Observer.cs                  # Padrão Observer
│   └── Structural/                      # (Para futuros padrões)
└── CSharpProject.csproj                # Configuração do projeto
```

## 🛠️ Padrões Implementados

### ✅ Criacionais (Creational)
- **Singleton** - Garante uma única instância da classe
- **Factory** - Cria objetos sem especificar suas classes concretas

### ✅ Comportamentais (Behavioral)  
- **Observer** - Define dependência um-para-muitos entre objetos

### 📋 Para Implementar
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
