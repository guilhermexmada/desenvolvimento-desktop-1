using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, H, b;

            Console.WriteLine("Digite o valor da base do triângulo: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            H = double.Parse(Console.ReadLine());

            S = (b * H) / 2;
            Console.WriteLine("A área desse triângulo vale: " + S);

            Console.ReadKey();
        }
    }
}
