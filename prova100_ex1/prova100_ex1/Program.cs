using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova100_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if(n%4 == 0)
                {
                    Console.WriteLine(n + " é múltiplo de 4");
                }
                else
                {
                    Console.WriteLine(" não é múltiplo de 4");
                }
            }
            Console.ReadKey();
        }
    }
}
