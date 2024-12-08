using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excase_parmenorque10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número para ver se ele é par ou ímpar e se é menor que 10");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("ímpar menor que 10");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("par menor que 10");
                    break;
                case 10:
                    Console.WriteLine("par igual a 10");
                    break;
                default:
                    Console.WriteLine("número fora do intervalo disponível");
                    break;
            }
            Console.ReadKey();

        }
    }
}
