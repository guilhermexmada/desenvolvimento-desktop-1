using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex40_triangulotipo
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;

            Console.WriteLine("Digite o valor do primeiro lado do triângulo: ");
            l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo lado do triângulo: ");
            l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro lado do triângulo: ");
            l3 = double.Parse(Console.ReadLine());

            if ((l1 == l2) && (l1 == l3))
            {
                Console.WriteLine("Este triângulo é equilátero pois todos os seus lados são iguais");
            }

            else if ((l1 == l2) || (l1 == l3) || (l2 == l3))
            {
                Console.WriteLine("Este triângulo é isóceles pois dois de seus lados são iguais");
            }
            else
            {
                Console.WriteLine("Este triângulo é escaleno pois todos os seus lados são diferentes");
            }

            Console.ReadKey();
        }
    }
}
