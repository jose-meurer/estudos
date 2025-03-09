namespace SequenciaDeEscapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saida de dados : Usando sequencia de escapes\n");

            string local = "c:\\dados\\poesias.txt";
            string frase = "Ele falou:\"Não fui eu\"";

            string pizza = "\nPizza\nde\nMussarela";
            string bolo = "\nBolo\tde\tChocolate";

            Console.WriteLine(pizza);
            Console.WriteLine(bolo);

            double x = 0.1 + 0.2;
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
