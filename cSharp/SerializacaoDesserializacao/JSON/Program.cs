// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization;

var aluno = new Aluno(id: 101, nome: "Maria", email: "maria@gmail.com", idade: 20);
var caminhoArquivo = @"c:\temp\alunoJson.json";

using(var stream = new FileStream(caminhoArquivo,FileMode.Create, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno);
}

Console.WriteLine("Objeto serializado para JSON com sucesso...");
Console.ReadKey();

var jsonContent = File.ReadAllText(caminhoArquivo);
var aluno2 = JsonSerializer.Deserialize<Aluno>(jsonContent);
Console.WriteLine($"Aluno JSON desserializado -> Id:{aluno2?.Id}, Nome:{aluno2?.Nome}, Email:{aluno2?.Email}, Idade:{aluno2?.Idade}");
Console.ReadKey();

public class Aluno
{
    public int Id { get; set; }

    [JsonPropertyName("Nome_do_aluno")]
    public string Nome { get; set; }
    public string Email { get; set; } //Se não tive o get e set, é ignorado da serializacao por default

    [JsonIgnore]
    public int Idade { get; set; }

    public Aluno() { }

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}