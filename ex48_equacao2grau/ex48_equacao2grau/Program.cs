using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex48_equacao2grau
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            Console.WriteLine("Digite o valor a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor c: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta) / 2 * a);
                x2 = (-b - Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("Primeira raíz = " + x1);
                Console.WriteLine("Segunda raíz = " + x2);
            }
            else if (delta == 0)
            {
                x1 = (-b + Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("Raízes iguais = " + x1);
            }
            else if(delta < 0)
            {
                Console.WriteLine("Não há raíz");
            }
            Console.ReadKey();
        }
    }
}
