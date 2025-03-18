using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        //var aluno = new Aluno() { Id = 101, Nome = "Maria", Email = "maria@gmail.com", Idade = 20 };
        //var aluno = new Aluno(101, "Maria", "maria@gmail.com", 20);
        var aluno = new Aluno(id: 101, nome: "Maria", email: "maria@gmail.com", idade: 20);

        var caminhoArquivo = @"c:\\temp\\test.xml";

        var serializer = new XmlSerializer(typeof(Aluno));
        
        //Serializar
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            serializer.Serialize(writer, aluno);
        }
        Console.WriteLine("Objeto serializado para XML com sucesso!");
        Console.ReadKey();

        //Desserializar
        using (var reader = new StreamReader(caminhoArquivo))
        {
            var aluno2 = serializer.Deserialize(reader) as Aluno;
            Console.WriteLine($"Aluno XML desserializado -> Id:{aluno2?.Id}, Nome:{aluno2?.Nome}, Email:{aluno2?.Email}");
        }

        Console.ReadKey();
    }
}

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    [XmlIgnore] //Ignora este campo na serialiacao para xml
    public int Idade { get; set; }

    public Aluno(){}

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}