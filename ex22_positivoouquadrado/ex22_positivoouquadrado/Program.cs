using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22_positivoouquadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, quadrado;

            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
            quadrado = Math.Pow(numero, 2);

            if (numero > 0)
            {
                Console.WriteLine("Sendo positivo, a metade de " + numero + " é " + numero / 2);
            }
            else if (numero == 0)
            {
                Console.WriteLine("Digite um número não nulo");
            }
            else
            {
                Console.WriteLine("Sendo negativo, o quadrado de " + numero + " é " + quadrado);
            }

            Console.ReadKey();
        }
    }
}
