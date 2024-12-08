using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex29_maiormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " é o maior e " + num2 + " é o menor");
            }
            else if(num1 == num2)
            {
                Console.WriteLine(num1 + " e " + num2 + " são iguais");
            }
            else
            {
                Console.WriteLine(num2 + " é o maior e " + num1 + " é o menor");
            }

            Console.ReadKey();

        }
    }
}
