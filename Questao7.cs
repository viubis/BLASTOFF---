using System;
 
namespace questao7
{
  class Questao7 
  {
    static void Main(string[] args) 
    {
      int a = int.Parse(Console.ReadLine());

      int b = int.Parse(Console.ReadLine());

      for (int i = a; i < b+1; i++)
      {
          if(i%2==0)
          {
              Console.Write(i);
              Console.Write(" ");
          }
      }
    }
  }
}
