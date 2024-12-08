using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex47_sencostg
{
    class Program
    {
        static void Main(string[] args)
        {
            double sen, cos, tg, ca, co, h;

            Console.WriteLine("CALCULADORA DE SENO, COSSENO E TANGENTE");
            Console.WriteLine("*Caso o valor seja desconhecido ou desnecessário, digite 0");
            Console.WriteLine("Digite o valor do cateto adjacente ao ângulo observado: ");
            ca = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto oposto ao ângulo observado: ");
            co = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hipotenusa: ");
            h = double.Parse(Console.ReadLine());

            sen = co / h;
            cos = ca / h;
            tg = co / ca;

            if(h == 0)
            {
                Console.WriteLine("TANGENTE = " + tg);
            }
            else if(ca == 0)
            {
                Console.WriteLine("SENO = " + sen);
            }
            else if(co == 0)
            {
                Console.WriteLine("COSSENO = " + cos);
            }
            Console.ReadKey();
        }
    }
}
