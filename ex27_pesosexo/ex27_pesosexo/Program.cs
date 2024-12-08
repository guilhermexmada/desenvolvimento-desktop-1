using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex27_pesosexo
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso_m, peso_f;
            string sexo;
             

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite F para feminino ou M para masculino: ");
            sexo = Console.ReadLine();

            peso_m = (72.7 * altura) - 58;
            peso_f = (62.1 * altura) - 44.7;

            if ((sexo == "F") || (sexo == "f"))
            {
                Console.WriteLine("Sua altura ideal seria de " + peso_f);
            }
            else if ((sexo == "M") || (sexo == "m"))
            {
                Console.WriteLine("Seu peso ideal seria de " + peso_m);
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

            Console.ReadKey();
        }
    }
}
