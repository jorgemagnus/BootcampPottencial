using ExemploPoo.Models;

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Jorge";
p1.Idade = 47;
p1.Apresentar();

Console.WriteLine("----------------------");

ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
*/

Console.WriteLine("----------------------");

Aluno a1 = new Aluno("Jorge");//<- usando construtor
a1.Idade = 17;
a1.Nota = 10;
a1.Apresentar();

Console.WriteLine("-----------------------");

Professor f1 = new Professor("Jorge"); //<- usando o construtor 
f1.Idade = 47;
f1.Salario = 1000;
f1.Apresentar();



Corrente c1 = new Corrente();
c1.Creditar(500);
c1.ExibirSaldo();

