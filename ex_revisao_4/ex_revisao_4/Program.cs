using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_revisao_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i=1; i<=40; i++)
            {
                soma = soma + i;
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}
