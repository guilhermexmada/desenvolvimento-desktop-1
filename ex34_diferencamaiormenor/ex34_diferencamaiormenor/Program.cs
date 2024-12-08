using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex34_diferencamaiormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A diferença entre " + num1 + " e " + num2 + " é de " + (num1 - num2));
            }
            else if (num2 > num1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A diferença entre " + num2 + " e " + num1 + " é de " + (num2 - num1));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A diferença de um número menos ele mesmo é 0, ora bolas");
            }
       
            Console.ReadKey();
        }
    }
}
