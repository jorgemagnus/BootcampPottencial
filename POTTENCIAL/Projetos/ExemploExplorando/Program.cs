using ExemploExplorando.Models;
using System.IO;
using System.Linq;
using System;
using System.Globalization;
using Newtonsoft.Json;


//Médoto de extensão.
int numero = 13;
bool par = false;

par = numero.EhPar();  //<- Foi criado uma classe IntExtensions e nela o metodo ehPar.

string mensagem = "O número " + numero + " " + "é " +(par ?  "par" : "impar");
Console.WriteLine(mensagem);


