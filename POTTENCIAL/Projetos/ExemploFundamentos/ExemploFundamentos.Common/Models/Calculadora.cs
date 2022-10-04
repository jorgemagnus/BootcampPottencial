using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
      /// <summary>
      /// Método que realiza uma soma de dois números.
      /// </summary>
      /// <param name="x">O primeiro número inteiro para soma</param>
      /// <param name="y">O primeiro segunto inteiro para soma</param>
       public void Somar(int x, int y)
       {
            Console.WriteLine($"{x} + {y} = {x + y}");
       }
         /// <summary>
         /// Método que realiza a subtração de dois números:
         /// </summary>
         /// <param name="x">O Primeiro número para subtrair</param>
         /// <param name="y">O Segundo número para subtrair</param>
         /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)      
       {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
       }

        public void Multiplicar(int x, int y)
       {
            Console.WriteLine($"{x} x {y} = {x * y}");
       }

        public void Dividir(int x, int y)
       {
            Console.WriteLine($"{x} / {y} = {x / y}");
       }

       public void Potencia(int x, int y)
       {
          double pot = Math.Pow(x,y);
          Console.WriteLine($"{x}^{y} = {pot}");
       }

       public void Seno(double angulo)
       {
          double radiano = angulo * Math.PI / 180;
          double seno = Math.Sin(radiano);
          Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno,4)}");
       }

        public void Coseno(double angulo)
       {
          double radiano = angulo * Math.PI / 180;
          double coseno = Math.Cos(radiano);
          Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno,4)}");
       }

        public void Tangente(double angulo)
       {
          double radiano = angulo * Math.PI / 180;
          double tangente = Math.Tan(radiano);
          Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente,4)}");
       }

       public void RaizQuadrada(double x)
       {
         double raiz = Math.Sqrt(x);
         Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
       }

    }
}