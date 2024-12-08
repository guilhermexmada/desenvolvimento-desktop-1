using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_for_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número final");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
