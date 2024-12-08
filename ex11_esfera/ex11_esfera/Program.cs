using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio;

            Console.WriteLine("Digite o raio da esfera: ");
            raio = double.Parse(Console.ReadLine());
            volume = (4/3)*3.14159 * Math.Pow(raio, 3);
            Console.WriteLine("O volume dessa esfera é de: " + volume);
            Console.ReadKey();
        }
    }
}
