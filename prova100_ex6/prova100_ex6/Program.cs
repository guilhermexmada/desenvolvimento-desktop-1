using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova100_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod;
            Console.WriteLine("Digite o código do produto: ");
            cod = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 1:
                    Console.WriteLine("alimento não perecível");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("alimento perecível");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("vestuário");
                    break;
                case 7:
                    Console.WriteLine("higiene pessoal");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("limpeza e utensílios domésticos");
                    break;
                default:
                    Console.WriteLine("código inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
