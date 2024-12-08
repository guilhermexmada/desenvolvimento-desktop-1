using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //crescente
            for(int i=1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            //decrescente
            for(int i=100; i >= 1; i--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
