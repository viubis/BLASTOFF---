using System;

namespace questao5
{
    class Questao5
    {
      static void Main(string[] args)
        {
          Console.WriteLine("Digite o valor a: ");
          int a = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite o valor b: ");
          int b = int.Parse(Console.ReadLine());

          if ( a % b == 0 || b % a == 0){
              Console.WriteLine("a e b são multiplos");
          }
          else{
              Console.WriteLine("a e b não são multiplos");
          }
        }
    }
}
