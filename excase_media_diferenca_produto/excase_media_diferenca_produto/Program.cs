using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excase_media_diferenca_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            int option;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de acordo com as opções: \n1 = média \n2 = diferença \n3 = produto");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("A média entre os números resulta em " + (n1 + n2) / 2);
                    break;
                case 2:
                    Console.WriteLine("A diferença entre os números resulta em " + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("O produto entre os números resulta em " + (n1 * n2));
                    break;
                default:
                    Console.WriteLine("O número não se encontra entre as opções");
                    break;
            }
            Console.ReadKey();
        }
    }
}
