using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_todasoperacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma, sub, mult, div;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + soma);
            Console.WriteLine(num1 + " - " + num2 + " = " + sub);
            Console.WriteLine(num1 + " * " + num2 + " = " + mult);
            Console.WriteLine(num1 + " / " + num2 + " = " + div);
            

            Console.ReadKey(); 
        }
    }
}
