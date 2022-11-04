using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa
    {
        
        public Pessoa(string nome)// construtor classe pai.
        {
            Nome = nome;
        }

        public string  Nome { get; set; }   
        public int Idade { get; set; }

        public virtual void Apresentar() //método pode ser sobescrito usando virtual
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}