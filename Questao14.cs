using System;
using System.Linq;

namespace palindromo
{
    class Questao14
    {
        public static bool verificaPalindromo(string mainString)
        {
            string primeiraParte = mainString.Substring(0, mainString.Length / 2);
            char[] arr = mainString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string segundaParte = temp.Substring(0, temp.Length / 2);

            return primeiraParte.Equals(segundaParte);
        }
        static void Main(string[] args)
        {
            bool palindrome = verificaPalindromo("osso");
            Console.WriteLine(palindrome);
        }
    }
}
