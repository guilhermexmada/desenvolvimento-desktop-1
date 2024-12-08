using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_igualoudiferente
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

            if(num1 == num2)
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("São diferentes");
            }
            Console.ReadKey();
        }
    }
}
