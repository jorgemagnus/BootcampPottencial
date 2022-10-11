using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;

try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrador /n "
    + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma execeção genérica. {ex.Message}");
}










