using System.Globalization;

namespace Finalizacao
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("## Entrada de dados ##\n");

            Console.Write("Nome :");
            string? nome = Console.ReadLine();

            Console.Write("Data de Nascimento :");
            DateTime nascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Salário :");

            decimal salario = Convert.ToDecimal(Console.ReadLine(),
                               CultureInfo.InvariantCulture); //Ignora a cultura local e usa a global

            Console.WriteLine($"\n{nome?.ToUpper()}");
            Console.WriteLine($"\n{nascimento.ToShortDateString()}");
            Console.WriteLine($"\n{salario.ToString("c")}"); //https://learn.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings

            Console.ReadKey();
        }
    }
}
