// Product
public interface ITransporte
{
    void Entregar();
}

// Concrete products
public class Caminhao : ITransporte
{
    public void Entregar() => Console.WriteLine("Entrega feita por caminhão!");
}

public class Navio : ITransporte
{
    public void Entregar() => Console.WriteLine("Entrega feita por navio!");
}

// Abstract creator
public abstract class TransporteFactory
{
    public abstract ITransporte CriarTransporte();
}

// Concrete creators
public class CaminhaoFactory : TransporteFactory
{
    public override ITransporte CriarTransporte() => new Caminhao();
}

public class NavioFactory : TransporteFactory
{
    public override ITransporte CriarTransporte() => new Navio();
}