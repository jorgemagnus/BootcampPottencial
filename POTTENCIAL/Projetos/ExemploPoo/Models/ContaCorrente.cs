using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroconta, decimal saldoInicial)
        {
            NumeroConta = numeroconta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!.");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + saldo);
        }
    }
}