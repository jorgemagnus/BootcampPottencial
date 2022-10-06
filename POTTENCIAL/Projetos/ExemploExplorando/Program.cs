using ExemploExplorando;

Pessoa p1 = new Pessoa();
Console.WriteLine("Digite se nome:");
p1.Nome = Console.ReadLine();
Console.WriteLine("Digite seu Sobrenome");
p1.Sobrenome = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
p1.Idade = Convert.ToInt32(Console.ReadLine());
p1.Apresentar();



