﻿using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;
using Newtonsoft.Json;

//new ExemploExcecao().Metodo1();
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($" Id: {venda.Id}\n Produto: {venda.Produto}\n" +
                      $" Preço: {venda.Preco}\n Data: {venda.DataVenda.ToString("dd/MM/yyy")}\n");
}