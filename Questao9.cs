using System;


namespace Questao9
{
    class Questao9
    {
        static void Main(string[] args)
        {
          int resultado, i, numero;

          Console.Write("Digite o Numero para obter a Taboada : ");
          numero = int.Parse(Console.ReadLine());

          for (i = 1; i <= 10; i++)
          {
              resultado =  numero * i;
              Console.WriteLine(numero + " * " + i + " = " + resultado);
          }
        }

    }
}
