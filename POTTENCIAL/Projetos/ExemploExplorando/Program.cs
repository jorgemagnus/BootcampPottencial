using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;


DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToString("dd/MM/yyyy"));
Console.WriteLine(data.ToString("dd-MM-yyyy"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());


/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //en-US  pt-BR

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}");

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

Console.WriteLine(valorMonetario.ToString("C3"));

Console.WriteLine(valorMonetario.ToString("N3"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/


/*
Pessoa p1 = new Pessoa();
Console.WriteLine("Digite se nome:");
p1.Nome = Console.ReadLine();
Console.WriteLine("Digite seu Sobrenome");
p1.Sobrenome = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
p1.Idade = Convert.ToInt32(Console.ReadLine());
p1.Apresentar();
*/

/*
Pessoa p1 = new Pessoa(nome:"Leonardo",sobrenome:"Buta",idade:40);
Pessoa p2 = new Pessoa(nome:"Eduardo",sobrenome:"Neves Queiroz",idade:30);

Console.WriteLine("bloco da classe Pessoa");
p1.Apresentar();
p2.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

Console.WriteLine("bloco da classe Curso");
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/





