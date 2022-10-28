using ExemploPoo.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Jorge";
p1.Idade = 47;
p1.Apresentar();


Console.WriteLine("----------------------");


ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();


