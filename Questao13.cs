using System;

namespace questao13
{
    class Questao13
    {
        static void Main(string[] args)
        {
          int[,] matriz = new int[2, 2];
          int i,j;

          for (i = 0; i<=2 ; i++){
              for( j = 0; j<=2; j++){
                  Console.WriteLine("digite o valor: ");
                  matriz[i,j] = int.Parse(Console.ReadLine());
              }

          }
          for (i = 0; i<=2 ; i++){
              for( j = 0; j<=2; j++){
                  Console.WriteLine(matriz[i,j]);
              }
          }
       }
    }
}
