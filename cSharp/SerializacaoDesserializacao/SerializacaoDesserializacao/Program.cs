
//var aluno = new Aluno() { Id = 101, Nome = "Maria", Email = "maria@gmail.com", Idade = 20 };
//var aluno = new Aluno(101, "Maria", "maria@gmail.com", 20);
using System.Runtime.Serialization.Formatters.Binary;

var aluno = new Aluno(id: 101, nome: "Maria", email: "maria@gmail.com", idade: 20);

var caminhoArquivo = @"c:\\temp\\test.bin";

using(FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    var bf = new BinaryFormatter();
    bf.Serialize(stream, aluno);
}

[Serializable]
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    [NonSerialized]
    public int Idade { get; set; }

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}