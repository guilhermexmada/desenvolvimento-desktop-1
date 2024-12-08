using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double comp, larg, per, area;

            Console.WriteLine("Digite o valor do comprimento do retângulo: ");
            comp = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da largura do retângulo: ");
            larg = double.Parse(Console.ReadLine());

            area = comp * larg;
            per = (2 * comp) + (2 * larg);

            Console.WriteLine("O perímetro desse retângulo equivale a " + per);
            Console.WriteLine("A área desse retângulo equivale a " + area);

        
            Console.ReadKey();
        }
    }
}
