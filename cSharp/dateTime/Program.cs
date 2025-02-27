namespace dateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## DateTime ##\n");

            DateTime data = DateTime.Now; //Diferente do java, aqui mes comeca em 1 e nao em 0
            Console.WriteLine(data);

            //criar data especifica usar o formato: aaaa, mm, dd
            DateTime data1 = new DateTime(2025, 02, 15);
            Console.WriteLine(data1);

            // criar data e hora especifica usar o formato: aaaa, mm, dd, hh, mm, ss
            DateTime data2 = new DateTime(2025, 01, 30, 21, 25, 46);

            //Convertendo de 24h para 12h
            Console.WriteLine(data2.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture)); 

            Console.WriteLine("\n  ------ Operações com data e hora ------- \n");

            DateTime date = DateTime.Now;

            //extraindo ano,mes,dia,hora,minuto,segundo, etc.
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Second);
            Console.WriteLine(date.Millisecond);

            //adicionar
            Console.WriteLine(date.AddDays(30));
            Console.WriteLine(date.AddHours(60));
            Console.WriteLine(date.AddMonths(1));
            Console.WriteLine(date.AddYears(10));

            // obter dia da semana e do ano
            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date.DayOfYear);

            //expressar data no formato longo e abreviado
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToShortDateString());

            //expressar hora no formato longo e abreviado
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.ToShortTimeString());

            Console.ReadKey();
        }
    }
}
