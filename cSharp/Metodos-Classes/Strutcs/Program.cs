internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Structs ##\n");

        Cliente cliente = new();
        cliente.Nome = "Maria";
        cliente.Idade = 19;

        Console.WriteLine($"{cliente.Nome} {cliente.Idade}");

        Console.ReadKey();
    }
}

public struct Cliente
{
    private string? nome;

    public string? Nome { get => nome; set => nome = value; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
