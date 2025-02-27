namespace tipos_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Numeros
             */

            int idade = 27;
            Console.WriteLine("int: " + idade);

            double valor = 2.5654;
            Console.WriteLine("double: " + valor); //precisao de 15~17 digitos

            float temperatura = 27.43F;
            Console.WriteLine("float: " + temperatura); //precisao de 6~9 digitos

            decimal medida = 27.43312312412312312312m; //Pode ser usado tanto m ou M
            Console.WriteLine("decimal: " + medida); //precisao de 28~29 digitos

            Console.WriteLine("Comparando a precisão de float, double e decimal");

            float x = 1f / 3f;
            double y = 1d / 3d;
            decimal z = 1m / 3m;

            Console.WriteLine("float: " + x);
            Console.WriteLine("double: " + y);
            Console.WriteLine("decimal: " + z);


            /*
             * Booleanos
             */

            bool status = true;
            Console.WriteLine("booleano: " + status);

            Console.WriteLine("Expressao booleana: " + (15 == 16));


            /*
             * Strings
             */

            //O tipo char pode expressar o caractere ou o valor unicode
            char letra = 'n';
            Console.WriteLine("char: " + letra);

            //as strings são tipos de referência e são imutáveis
            string nome = "Jose Meurer";
            Console.WriteLine("string: " + nome);

            //aqui estamos criando 3 strings distintas na memória, que posteriormente as não usadas serão coletadas pelo garbage colletor
            string str = "Isto é uma string";
            str = "Isto é uma string alterada";
            str = "teste";

            /*
             * Dinamicos
             */

            // var e dynamic sao parecidos, porem var define o valor em tempo de compilacao, 
            // enquanto dynamic é tratado em tempo de execucao

            var rua = "Rua do João";
            // rua = 19; //erro
            Console.WriteLine("var: " + rua);

            //o tipo dynamic tem um comportamento igual ao object, mas são resolvidos em tempo de execução(runtime)
            dynamic cor = "Azul";
            Console.WriteLine("dynamic: " + cor);
            cor = 19; //funciona
            Console.WriteLine("Novo tipo atribuido para o dynamic: " + cor);

            Object obj = "Valor de Obj";
            Console.WriteLine("Object: " + obj);

            Console.ReadLine();
        }
    }
}
