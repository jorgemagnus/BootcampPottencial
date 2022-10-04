using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    ///  Classe que representa uma pessoa física. 
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }       
        public int Idade { get; set; }

        /// <summary>
        /// Método que faz a pessoa se apresentar, dizendo seu nome e idade.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"OLá, meu nome é {Nome} \n e vou ter {Idade+1} anos em Novembro.");
        }
    }
}