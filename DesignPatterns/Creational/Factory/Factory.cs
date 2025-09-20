using System;

// Abstract product
public abstract class Veiculo
{
    public abstract void ExibirInfo();
}

// Concrete products
public class Carro : Veiculo
{
    public override void ExibirInfo() => Console.WriteLine("Sou um carro!");
}

public class Moto : Veiculo
{
    public override void ExibirInfo() => Console.WriteLine("Sou uma moto!");
}

// Factory
public static class VeiculoFactory
{
    public static Veiculo CriarVeiculo(string tipo)
    {
        return tipo.ToLower() switch
        {
            "carro" => new Carro(),
            "moto" => new Moto(),
            _ => throw new ArgumentException("Tipo de veículo inválido")
        };
    }
}
