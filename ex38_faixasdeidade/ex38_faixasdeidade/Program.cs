using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38_faixasdeidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade == 0)
            {
                Console.WriteLine("Você é um recém-nascido");
            }
            else if ((idade >= 1) && (idade <= 5))
            {
                Console.WriteLine("Você é uma criança");
            }
            else if ((idade >= 6) && (idade <= 10))
            {
                Console.WriteLine("Você é um garotinho");
            }
            else if ((idade >= 11) && (idade <=15))
                {
                Console.WriteLine("Você é um pré-adolescente");
            }
            else if ((idade >= 16) && (idade <= 25))
            {
                Console.WriteLine("Você é um jovem");
            }
            else if ((idade >= 26) && (idade <= 45))
            {
                Console.WriteLine("Você é um adulto");
            }
            else if ((idade >= 46) && (idade <= 60))
            {
                Console.WriteLine("Você é um adulto experiente");
            }
            else if ((idade >= 61) && (idade <= 120))
            {
                Console.WriteLine("Você já está bem idoso");
            }
            else
            {
                Console.WriteLine("Você já morreu");
            }

            Console.ReadKey();
        }
    }
}
