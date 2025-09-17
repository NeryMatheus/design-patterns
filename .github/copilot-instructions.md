# Instruções para o Copilot

<!-- Use este arquivo para fornecer instruções personalizadas específicas do workspace para o Copilot. Para mais detalhes, visite https://code.visualstudio.com/docs/copilot/copilot-customization#_use-a-githubcopilotinstructionsmd-file -->

## Contexto do Projeto

Este é um projeto C# Console Application (.NET 9.0) para estudo e implementação prática de Design Patterns. O foco é criar exemplos simples e didáticos de cada padrão, com cada implementação em arquivos separados para facilitar o aprendizado.

## Diretrizes de Código

- Use convenções de nomenclatura C# (PascalCase para classes, métodos e propriedades, camelCase para variáveis locais)
- Mantenha o código simples e didático - priorize clareza sobre complexidade
- Adicione comentários explicativos em português para facilitar o entendimento
- Use emojis nos Console.WriteLine para tornar a saída mais visual (ex: 🔧, 📋, ✅)
- Implemente interfaces quando apropriado para demonstrar abstrações
- Cada padrão deve ter exemplos de uso prático no método Main() do Program.cs
- Prefira métodos estáticos para testes e demonstrações
- Mantenha tratamento de exceções simples mas presente quando necessário

## Estrutura Atual do Projeto

```
design_patterns/
├── Program.cs                                    # Ponto de entrada com testes dos padrões
├── CSharpProject.csproj                         # Configuração do projeto .NET 9.0
├── DesignPatterns/
│   ├── Creational/                              # Padrões Criacionais
│   │   └── Singleton/                           # Implementações do Singleton
│   │       ├── Singleton.cs                    # Implementação básica
│   │       ├── SingletonLazy.cs               # Implementação Lazy
│   │       └── SingletonLogger.cs             # Exemplo prático (Logger)
│   ├── Behavioral/                             # Padrões Comportamentais
│   └── Structural/                             # Padrões Estruturais
└── .github/
    └── copilot-instructions.md                # Este arquivo
```

## Design Patterns Implementados

### Padrões Criacionais (Creational)
- **Singleton** - Múltiplas implementações (básica, lazy, logger)
  - Foco em thread-safety e diferentes abordagens de implementação

### Padrões a Implementar
- **Factory Method** - Para criação de objetos relacionados
- **Observer** - Para notificações e eventos
- **Strategy** - Para algoritmos intercambiáveis
- **Decorator** - Para extensão de funcionalidades
- **Adapter** - Para compatibilidade entre interfaces

## Convenções Específicas

### Organização de Arquivos
- Cada padrão deve ter sua própria pasta dentro da categoria apropriada
- Múltiplas implementações do mesmo padrão ficam na mesma pasta
- Nomes de arquivo devem ser descritivos (ex: SingletonLogger.cs)

### Testes e Demonstrações
- Cada padrão deve ter um método Test{Pattern}() no Program.cs
- Use separadores visuais (---) entre diferentes testes
- Inclua verificações que demonstrem o funcionamento do padrão
- Sempre mostre resultados na console para validação

### Comentários e Documentação
- Use /// para documentação XML em classes e métodos públicos
- Adicione comentários inline em português para explicar conceitos
- Inclua exemplos de uso prático sempre que possível

## Comandos de Build e Execução

- **Build:** `dotnet build CSharpProject.csproj`
- **Run:** `dotnet run --project CSharpProject.csproj`
- **VS Code:** F5 para debug, Ctrl+F5 para executar sem debug
