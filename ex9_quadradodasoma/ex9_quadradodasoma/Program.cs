using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_quadradodasoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, soma;
            double quadrado_soma;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            soma = num1 + num2 + num3;
            quadrado_soma = Math.Pow(soma, 2);
            Console.WriteLine("O quadrado da soma dos 3 números dá " + quadrado_soma);



            Console.ReadKey();

        }
    }
}
