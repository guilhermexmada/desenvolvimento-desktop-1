using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_revisao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Digite uma letra");
            letra = Console.ReadLine();
            switch (letra)
            {
                case "a":
                case "A":
                case "e":
                case "E":
                case "I":
                case "i":
                case "o":
                case "O":
                case "u":
                case "U":
                    Console.WriteLine("É uma vogal");
                    break;
                default:
                    Console.WriteLine("É consoante");
                    break;
            }
            Console.ReadKey();
        }
    }
}
