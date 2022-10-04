using System;

class DIO{

static void Main(string[] args)
{
     
        Console.WriteLine("Informe Opção 1 = 234 ou Opção 2 = 4421");

        int numeroInformado = 0, 
        opcaoSelecionada = 0;

        opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

        if (opcaoSelecionada == 1)
         {
             numeroInformado = 234;
         }
         else if (opcaoSelecionada == 2)
        {
             numeroInformado = 4421;
         }
         else
         {
             Console.WriteLine("Opção inválida!");            
         }  
       
        
        List<int> ListaNumeros = new List<int>();
        while (numeroInformado > 0)
        {
            
            ListaNumeros.Add(numeroInformado % 10);
            numeroInformado = numeroInformado / 10;
            
        }

        ListaNumeros.Reverse();

         int contadorForeach = 0;
        foreach(int numLista in ListaNumeros)
         {
          Console.WriteLine($"Posição Nº {contadorForeach} - {numLista}");
            contadorForeach++;
         }

        int p = 0, s = 0;


        if (ListaNumeros.Count == 3)
        {
            p = ListaNumeros[0] * ListaNumeros[1] * ListaNumeros[2];
            s = ListaNumeros[0] + ListaNumeros[1] + ListaNumeros[2];
            Console.WriteLine(Convert.ToInt32(p - s));
          
        } else if (ListaNumeros.Count == 4)
        {
           p = ListaNumeros[0] * ListaNumeros[1] * ListaNumeros[2] * ListaNumeros[3];
           s = ListaNumeros[0] + ListaNumeros[1] + ListaNumeros[2] + ListaNumeros[3];
            Console.WriteLine(Convert.ToInt32(p - s));            
        }else
        {
            Console.WriteLine("Não foi informado um valor válido!");
        }

               
    }

}


