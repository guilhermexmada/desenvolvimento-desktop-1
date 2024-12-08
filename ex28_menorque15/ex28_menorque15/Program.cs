using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex28_menorque15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            
            if(num < 15)
            {
                Console.WriteLine(num + " é menor que 15");
            }
            else if(num == 15)
            {
                Console.WriteLine("Digite um número menor que 15");
            }
            else
            {
                Console.WriteLine("Digite um número menor que 15");
            }
            Console.ReadKey();

        }
    }
}
