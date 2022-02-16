using System;

namespace questao3
{
    class Questao3
    {
        static void Main(string[] args)
        {
          int a,b,c;
          a=3;
          b=4;
          c=5;
          if (a > b)
          {
              if(a > c) 
                  Console.WriteLine(" O maior é o valor de A = " + a);
              else 
                  Console.WriteLine(" O maior é o valor de C = " + c);
          }
          else    
          {
              if (b > c)
                  Console.WriteLine(" O maior é o valor de B = " + b);
              else 
                  Console.WriteLine(" O maior é o valor de B = " + c);
          }
        }
     }
}
