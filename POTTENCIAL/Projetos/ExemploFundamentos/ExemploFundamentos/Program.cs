// Para usar as classes  que estão no Common.Models
using ExemploFundamentos.Common.Models; 

//Exemplo de comentários de uma linha.

// Instância da classe pessoa
Pessoa p = new Pessoa();


/*
  Fazendo comentários em varias linhas(texto grande.)
  Atribuir o nome e idade para pessoa
  passando o nome jorge
  passando a idade 47
  e pode escrever várias linhas aqui
  linha ....  
*/

p.Nome = "Jorge";
p.Idade = 47;

// Faz a pessoa se apresentar.
p.Apresentar();

Calculadora calc = new Calculadora();
calc.Somar(3, 4);
calc.Subtrair(3, 5);