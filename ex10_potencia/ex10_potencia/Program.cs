using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double potencia, num_1, num_2;

            Console.WriteLine("Digite a base da potência: ");
            num_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente da potência: ");
            num_2 = double.Parse(Console.ReadLine());

            potencia =  Math.Pow(num_1, num_2);
            Console.WriteLine(num_1 + " ^ " + num_2 + " = " + potencia);

            Console.ReadKey();
        }
    }
}
