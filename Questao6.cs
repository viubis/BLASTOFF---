using System;

namespace questao6
{
    class Questao6
    {
        static void Main(string[] args)
        { 
          int duracao;
          Console.WriteLine("hora de inicio: ");
          int inicio = int.Parse(Console.ReadLine());
          Console.WriteLine("hora de termino: ");
          int termino = int.Parse(Console.ReadLine());

          if (inicio >= termino){
              duracao = (24 - inicio) + termino;
              Console.WriteLine("duraçao em hrs: " + duracao);

          }
          else{
              duracao = termino - inicio;
              Console.WriteLine("duraçao em hrs: " + duracao);    
          }
        }
    }
}
