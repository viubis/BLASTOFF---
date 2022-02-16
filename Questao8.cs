using System;
 
namespace questao8
{
  class Questao8
  {
    static void Main(string[] args) 
    {
      bool primo = true; 
      Console.Write("Informe um número inteiro e positivo: ");
      int numero = int.Parse(Console.ReadLine());

      if (numero < 0)
      {
          Console.WriteLine("Número negativo.");
      }
      else if ((numero == 0) || (numero == 1))
      {
          Console.WriteLine("O valor é 0 ou 1.");
      }
      else 
      {
          for (int i = 2; i <= (numero / 2); i++) {

              if (numero % i == 0) {
                  primo = false; 
                  break;
              }
          }
          if (primo == true) 
          {
              Console.WriteLine("O número informado é primo");
          }
          else 
          {
              Console.WriteLine("O número informado não é primo");
          }
      }
    }
  }
 }
