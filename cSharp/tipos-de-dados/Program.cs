class Program
{

    static void Main()
    {
        int idade = 27;
        Console.WriteLine("int: " + idade);

        double valor = 2.5654;
        Console.WriteLine("double: " + valor); //precisao de 15~17 digitos

        float temperatura = 27.43F;
        Console.WriteLine("float: + " + temperatura); //precisao de 6~9 digitos

        decimal medida = 27.43312312412312312312m;
        Console.WriteLine("decimal: + " + medida); //precisao de 28~29 digitos

        bool status = true;
        Console.WriteLine("booleano: " + status);

        char letra = 'n';
        Console.WriteLine("char: " + letra);

        string nome = "Jose Meurer";
        Console.WriteLine("string: " + nome);

        // var e dynamic sao parecidos, porem var define o valor em tempo de compilacao, 
        // enquanto dynamic é tratado em tempo de execucao

        var rua = "Rua do João";
        Console.WriteLine("var: " + rua);

        // rua = 19; //erro

        dynamic cor = "Azul";
        Console.WriteLine("dynamic: " + cor);

        // cor = 19; //funciona
    }
}