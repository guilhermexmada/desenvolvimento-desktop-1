using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_decrescentemaiormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1>num2)
            {
                Console.WriteLine(num1 + "," + num2);
            }
            else
            {
                Console.WriteLine(num2 + "," + num1);
            }
            Console.ReadKey();


        }
    }
}
