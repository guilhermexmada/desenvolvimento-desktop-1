using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20_maiormenorigual30
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_1, num_2, soma;

            Console.WriteLine("Digite o primeiro número");
            num_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num_2 = double.Parse(Console.ReadLine());

            soma = num_1 + num_2;

            if (soma > 30)
            {
                Console.WriteLine(num_1 + " + " + num_2 + " > 30 ");
            }
            else if(soma == 30)
            {
                Console.WriteLine(num_1 + " + " + num_2 + " = 30 ");
            }
            else
            {
                Console.WriteLine(num_1 + " + " + num_2 + " < 30");
            }


            Console.ReadKey();
        }
    }
}
