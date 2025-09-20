// Product
public interface IConexaoBD
{
    void Conectar();
}

// Concrete products
public class SqlServerConexao : IConexaoBD
{
    public void Conectar() => Console.WriteLine("Conectado ao SQL Server!");
}

public class PostgreSqlConexao : IConexaoBD
{
    public void Conectar() => Console.WriteLine("Conectado ao PostgreSQL!");
}

// Factory
public static class ConexaoFactory
{
    public static IConexaoBD CriarConexao(string tipo)
    {
        return tipo.ToLower() switch
        {
            "sqlserver" => new SqlServerConexao(),
            "postgresql" => new PostgreSqlConexao(),
            _ => throw new ArgumentException("Tipo de banco inválido")
        };
    }
}