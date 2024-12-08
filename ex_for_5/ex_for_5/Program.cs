using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_for_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine((n / 2));
            }
            Console.ReadKey();
        }          
    }
}
