// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var date = "2025/10/05";
var dateConverted = date.ToDateTime();
Console.WriteLine(dateConverted);
Console.WriteLine(dateConverted.GetType());

//var idade = 20;
//var conversao = idade.ToDateTime();

var aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Idade = 20;

Console.WriteLine($"{aluno.Nome} + {aluno.Idade}");

var aluno2 = aluno.ToNameAluno();
Console.WriteLine($"{aluno.Nome} + {aluno.Idade}");



public static class StringExtension
{
    public static DateTime ToDateTime(this string time)
    {
        var date = time.Split("/");
        return new DateTime(
                int.Parse(date[0]),
                int.Parse(date[1]),
                Convert.ToInt32(date[2])
            );
    }
}

public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }

}

public static class AlunoConverter
{
    public static Aluno ToNameAluno(this Aluno aluno)
    {
        aluno.Nome = "Joao";
        return aluno;
    }
}
