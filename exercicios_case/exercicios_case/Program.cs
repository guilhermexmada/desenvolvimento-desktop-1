using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double dm, cm, mm, m;

            Console.WriteLine("Digite a medida em metros para conversão segundo o quadro abaixo: ");
            Console.WriteLine("decímetros = 1 \ncentímetros = 2 \nmilímetros = 3");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número segundo a tabela: ");
            x = int.Parse(Console.ReadLine());

            switch (x) {
                case 1:
                    dm = m * 10;
                    Console.WriteLine(m + " metros equivale a " + dm + "decímetros");
                    break;

                case 2:
                    cm = m * 100;
                    Console.WriteLine(m + " metros equivale a " + cm + " centímetros ");
                    break;

                case 3:
                    mm = m * 1000;
                    Console.WriteLine(m + " metros equivale a " + mm + " milímetros ");
                    break;

            }
            Console.ReadKey();
        }
    }
}
