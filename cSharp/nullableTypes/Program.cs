namespace nullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Nullable Types ##\n");

            Nullable<int> i = null;
            Nullable<bool> b = null;
            Nullable<double> d = null;
            Nullable<float> f = null;

            Console.WriteLine($"i={i}");
            Console.WriteLine($"b={b}");
            Console.WriteLine($"d={d}");
            Console.WriteLine($"f={f}");

            //Forma simplificada de Nullable
            int? vari = null;
            bool? varb = null;
            double? vard = null;
            float? varf = null;

            Console.WriteLine($"i={vari}");
            Console.WriteLine($"b={varb}");
            Console.WriteLine($"d={vard}");
            Console.WriteLine($"f={varf}");


            int a1 = 100;
            int? b1 = a1;
            Console.WriteLine(b1);

            int? a2 = null;
            int b2 = a2 ?? 0; //Similar com curto-circuito do js, int != de int?, int? recebe int, mas int nao recebe int?
            Console.WriteLine(b2);

            int? x = 4;
            int y = 3;
            //int z = x * y;
            //Console.WriteLine(z);

            int? x1 = 4;
            int y1 = 3;
            int? z1 = x1 * y1; //A variavel que recebe a expressao tambem precisa ser Nullable
            Console.WriteLine(z1);

            //b3.Value, está retornando o valor subjacente do tipo T
            int? b3 = 103;
            if (b3.HasValue)
            {
                Console.WriteLine($"b3 is {b3.Value}");
            }
            else
            {
                Console.WriteLine("b3 does not have a value");
            }

            Console.ReadKey();
        }
    }
}
