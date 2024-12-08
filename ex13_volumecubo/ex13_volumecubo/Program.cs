using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13_volumecubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, volume, area_base;

            Console.WriteLine("Digite o comprimento do lado do cubo: ");
            lado = double.Parse(Console.ReadLine());
            area_base = Math.Pow(lado, 2);
            volume = Math.Pow(lado, 3);
            Console.WriteLine("A área da base do cubo equivale a " + area_base);
            Console.WriteLine("O volume do cubo equivale a " + volume);
            Console.ReadKey();
        }
    }
}
