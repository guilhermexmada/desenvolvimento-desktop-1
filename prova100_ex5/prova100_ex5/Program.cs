using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova100_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int publico;
            Console.WriteLine("Digite a quantidade de pessoas presentes no show: ");
            publico = int.Parse(Console.ReadLine());
            if(publico <= 7000)
            {
                Console.WriteLine("SHOW RUIM, SEM PÚBLICO");
            }
            else if((publico >= 7001)&&(publico <= 30000))
            {
                Console.WriteLine("SHOW LOTADO, BÃO DEMAIS");
            }
            else
            {
                Console.WriteLine("SHOW SUPER LOTADO, EHHH SERTANEJÃO");
            }
            Console.ReadKey();
        }
    }
}
