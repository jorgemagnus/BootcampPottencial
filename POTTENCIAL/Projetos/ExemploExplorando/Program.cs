using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;

//new ExemploExcecao().Metodo1();

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}








