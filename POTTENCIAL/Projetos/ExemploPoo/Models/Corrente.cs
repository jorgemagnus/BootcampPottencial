using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Corrente : Conta // Classe Conta é abstrata. 
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}