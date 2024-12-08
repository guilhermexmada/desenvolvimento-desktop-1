using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_revisao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto;

            for (int i = 1; i <= 250; i++)
            {
                resto = i % 2;
                if(resto != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
