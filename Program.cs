using CSharp.Models;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");







/*
List<string> listaString = new List<string>();

listaString.Add("ES");
listaString.Add("MG");
listaString.Add("RJ");
listaString.Add("SP");

Console.WriteLine($"itens na lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

Calculadora c = new Calculadora();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
c.Somar(a, b);
c.Subtrair(a, b);
c.Multiplicar(a, b);
c.Dividir(a, b);


*/
Pessoa p1 = new Pessoa("renan", "Oliveira");

Pessoa p2 = new Pessoa("ruan", "Santos");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Ingles";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();

//p.Idade = 28;
//p.Apresentar();
/*
string idade1 = Console.ReadLine();
switch (idade1)
{
    case "25":
    case "26":
    case "27":
    case "28":
        Console.WriteLine($"Tem {idade1}");
        break;

    default:
        Console.WriteLine($"Não tem idade válida!");
        break;
}
*/
