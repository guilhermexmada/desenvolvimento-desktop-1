using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex19_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, IMC;

            Console.WriteLine("Digite seu peso em kg: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura em m: ");
            altura = double.Parse(Console.ReadLine());

            IMC = peso / (Math.Pow(altura, 2));
            Console.WriteLine("Seu IMC é igual a " + IMC);
            Console.ReadKey();
        }
    }
}
