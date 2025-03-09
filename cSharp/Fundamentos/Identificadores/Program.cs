namespace Identificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *    CamelCase -> variaveis, parametros, propriedades privadas;
             *    
             *    PascalCase -> nome classe, metodos, intefaces, propriedades publicas;
             *    
             *    Tudo maiusculas -> constantes;
             *    
             *    Sublinhado -> propriedades privadas somente leitura;
             *      
             */


            Console.WriteLine("Definindo Identificadores\n");

            //identificadores válidos
            string nome;
            string nomeCompleto;
            int idade;
            int _valor;
            int idade1;

            //idenficadores inválidos
            //int 5idade;
            //int $valor;
            //int valor#total;
            //string nome Completo;

            //para nomes de variáveis : usa a convenção camel case
            string descontoTotal;
            string desconto_Total;

            //constantes : recomendação é usar maiúsculas
            double PI = 3.1415;
            string PREFIXO = "11";
            string PREFIXO_SP = "11";

            ImprimirTexto imprimir = new ImprimirTexto();
            imprimir.ImprimeNome();

            Console.ReadLine();
        }
    }

    class ImprimirTexto
    {
        public void ImprimeNome()
        {
            Console.WriteLine("Identificadores");
        }
    }
}
