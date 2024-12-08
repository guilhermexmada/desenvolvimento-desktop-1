using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2_circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARS
            double raio, area;
            //EXECUÇÃO
            Console.WriteLine("Digite o valor da raio da circunferência: ");
            raio = double.Parse(Console.ReadLine());
            area = (3.14 * (raio * raio));
            Console.WriteLine("A área da circunferência mede " + area);
            Console.ReadKey();
        }
    }
}
