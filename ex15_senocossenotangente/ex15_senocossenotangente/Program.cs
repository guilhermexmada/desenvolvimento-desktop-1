using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_senocossenotangente
{
    class Program
    {
        static void Main(string[] args)
        {
            double sen, cos, tg, cat_op, cat_ad, hipot;

            Console.WriteLine("Este é um programa de cálculo de propriedades dos triângulos; ");
            Console.WriteLine("Digite o valor da hipotenusa: ");
            hipot = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto oposto ao ângulo específico: ");
            cat_op = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto adjacente à este ângulo: ");
            cat_ad = double.Parse(Console.ReadLine());

            sen = cat_op/hipot;
            cos = cat_ad / hipot;
            tg = cat_op / cat_ad;

            Console.WriteLine("O seno deste ângulo é " + sen + ", o cosseno é " + cos + " e a tangente é " + tg);
       
     
            Console.ReadKey();

        }
    }
}
