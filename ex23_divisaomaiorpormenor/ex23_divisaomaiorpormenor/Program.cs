using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex23_divisaomaiorpormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_1, num_2, div_12, div_21;

            Console.WriteLine("Digite o primeiro número: ");
            num_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num_2 = double.Parse(Console.ReadLine());

            div_12 = num_1 / num_2;
            div_21 = num_2 / num_1;

            if (num_1 > num_2)
            {
                Console.WriteLine(num_1 + " / " + num_2 + " = " + div_12);
            }
            else if (num_1 == num_2)
            {
                Console.WriteLine("Qualquer número dividido por ele mesmo resulta em 1");
            }
            else
            {
                Console.WriteLine(num_2 + " / " + num_1 + " = " + div_21);
            }

            Console.ReadKey();
        }
    }
}
