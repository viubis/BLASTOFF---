using System;

namespace Questao10
{
    class Questao10
    {
        static void Main(string[] args)
        {
          double i, numero, fatorial;
          Console.WriteLine("Informe o número para fatorar: ");
          fatorial = double.Parse(Console.ReadLine());

          numero = fatorial;
          for (i = numero - 1; i >= 1; i--)
          {
              Console.WriteLine($"{fatorial} * {i}");
              fatorial = fatorial * i;

          }
          Console.WriteLine($"\nO fatorial de {numero} é {fatorial}. ");
          Console.ReadLine();
        }
    }
}
