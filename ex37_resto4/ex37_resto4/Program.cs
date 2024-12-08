using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex37_resto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r4;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            r4 = num % 4;

            if (r4 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("É divisível por 4");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é divisível por 4");
            }

            Console.ReadKey();
        }
    }
}
