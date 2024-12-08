using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_lataoleo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.WriteLine("Digite o raio da lata de óleo cilíndrica: ");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da lata de óleo: ");
            altura = double.Parse(Console.ReadLine());

            volume = 3.14159 * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da lata de óleo é de " + volume);
            Console.ReadKey();

        }
    }
}
