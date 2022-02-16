using System;

namespace questao11
{
    class Questao11
    {
      static void Main(string[] args)
       { 
        int[] vetor1 = new int[] { 1, 2, 3, 4 } ;
        int[] vetor2 = new int[] { 1, 2, 5, 8 };

        StringBuilder builderInterseccao = 
            new StringBuilder("Interseccção: ");


        IEnumerable<int> inter = vetor1.Intersect(vetor2);
        foreach (int numero in inter)
            builderInterseccao.Append(numero).Append(" ");


        Console.WriteLine(builderInterseccao);
       }
    }
}
