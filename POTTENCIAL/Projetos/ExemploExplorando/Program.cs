﻿using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;

//new ExemploExcecao().Metodo1();

LeituraArquivo arquivo = new LeituraArquivo(); //ver classe LeituraArquivo.cs

//se eu não quero usar uma variável da tupa, basta substituir por "_".
//var(sucesso, linhasArquivo, _) 

var(sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo é: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}



/*
//recomendavel usar essa forma.
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Jorge", "Antunino", 1.80M); 

// ValueTask<int, string, string, decimal> tupla2 = (1, "Jorge", "Antunino", 1.80M); não recomendável.

// var tupla3 = Tuple.Create(1, "Jorge", "Antunino", 1.80M); não recomendável.


Console.WriteLine($"ID: {tupla.Id}");
Console.WriteLine($"nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

*/