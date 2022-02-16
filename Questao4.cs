using System;

namespace Questao4
{
    class Questao4
    {
        static void Main(string[] args)
        {      
          double grausCelsius, grausFahrenheit;
          Console.Write("Digite o valor do graus celsius: ");
          grausCelsius = double.Parse(Console.ReadLine());
          grausFahrenheit=1.8*grausCelsius+32;
          Console.WriteLine("O valor em graus Fahrenheit: " + grausFahrenheit);
          Console.WriteLine();
        }
    }
}
