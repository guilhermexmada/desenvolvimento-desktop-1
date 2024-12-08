using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova100_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int litros;
            string tipoCombustivel;
            Console.WriteLine("Digite o tipo do combustível comprado (G para gasolina e A para álcool): ");
            tipoCombustivel = Console.ReadLine();
            Console.WriteLine("Digite o número inteiro de litros comprados: ");
            litros = int.Parse(Console.ReadLine());
            switch (tipoCombustivel)
            {
                case "A":
                case "a":
                    Console.WriteLine("O valor a ser pago é de R$ " + (4.89 * litros));
                    break;
                case "G":
                case "g":
                    Console.WriteLine("O valor a ser pago é de R$ " + (5.39 * litros));
                    break;
                default:
                    Console.WriteLine("Erro - tente novamente");
                    break;
            }
            Console.ReadKey();
        }
    }
}
