﻿namespace OperadoresAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Operadores de atribuição ##\n");

            //usando operadores atribuição com tipos numéricos
            float x = 10;
            x = 20;
            Console.WriteLine($"Valor inicial de x ={x}");
            Console.WriteLine($"x+=5 ==> {x += 5}");
            Console.WriteLine($"x-=3 ==> {x -= 3}");
            Console.WriteLine($"x*=4 ==> {x *= 4}");
            Console.WriteLine($"x/=5 ==> {x /= 5}");
            Console.WriteLine($"x%=5 ==> {x %= 5}");

            //operador + e += com string (concatenação)
            string y = "123";
            Console.WriteLine($"Valor inicial de y= {y}");

            y += "456";
            Console.WriteLine($"y+=\"456\" ==> {y}");

            Console.ReadKey();
        }
    }
}
