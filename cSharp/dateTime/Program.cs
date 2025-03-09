using System.Globalization;

namespace dateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## DateTime ##\n");

            DateTime timeZero = new DateTime();
            Console.WriteLine($"timeZero: {timeZero}");

            DateTime data = DateTime.Now; //Diferente do java, aqui mes comeca em 1 e nao em 0
            Console.WriteLine(data);

            //criar data especifica usar o formato: aaaa, mm, dd
            DateTime data1 = new DateTime(2025, 02, 15);
            Console.WriteLine(data1);

            // criar data e hora especifica usar o formato: aaaa, mm, dd, hh, mm, ss
            DateTime data2 = new DateTime(2025, 01, 30, 21, 25, 46);

            //Trabalhando com datas ISO8601
            Console.WriteLine("\n ISO 8601 ");
            string dataFormatoIso8601 = "2025-03-08T20:55:30Z";

            DateTime data3 = DateTime.Parse(dataFormatoIso8601);
            Console.WriteLine(data3); //08/03/2025 17:55:30 Converteu para o fuso local
            Console.WriteLine(data3.ToString("O")); //2025-03-08T17:55:30.0000000-03:00

            DateTimeOffset dataOffset = DateTimeOffset.Parse(dataFormatoIso8601); //DateTimeOffset mantem o fuso
            Console.WriteLine(dataOffset); //08/03/2025 20:55:30 +00:00

            //Cria data atual utc
            DateTime agoraUtc = DateTime.UtcNow;
            string iso8601Utc = agoraUtc.ToString("yyyy-MM-ddTHH:mm:ssZ");
            Console.WriteLine(agoraUtc + " -> " + iso8601Utc); //08/03/2025 22:41:47 -> 2025-03-08T22:41:47Z


            //Convertendo de 24h para 12h
            Console.WriteLine(data2.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture));

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

            Console.WriteLine("\n  ------ DateTime em milissegundos desde a época Unix  ------- \n");

            DateTime dateUtc = DateTime.UtcNow;
            long timestamp = new DateTimeOffset(dateUtc).ToUnixTimeMilliseconds();
            Console.WriteLine("timestamp: " + timestamp);
            //Console.WriteLine(new DateTimeOffset(dateUtc).ToUnixTimeSeconds());

            Console.WriteLine("\n  ------ Converter DateTime para UTC  ------- \n");

            DateTime dateLocal = DateTime.Now;
            DateTimeOffset dateConvertidoUtc = new DateTimeOffset(dateLocal).ToUniversalTime();
            Console.WriteLine(dateConvertidoUtc);
            Console.WriteLine(dateConvertidoUtc.ToString("yyyy-MM-ddTHH:mm:ssZ"));


            Console.ReadKey();
        }
    }
}
