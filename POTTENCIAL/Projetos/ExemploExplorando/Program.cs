using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;

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


Pessoa p1 = new Pessoa(nome:"Leonardo",sobrenome:"Buta");
Pessoa p2 = new Pessoa(nome:"Eduardo",sobrenome:"Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

