using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;
using Newtonsoft.Json;

//new ExemploExcecao().Metodo1();
Venda v1 = new Venda(1, "Material de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

//escrevendo em um arquivo json
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);