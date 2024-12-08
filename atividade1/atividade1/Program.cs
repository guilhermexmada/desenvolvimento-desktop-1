using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1: SOMA
            int num1, num2, soma;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("O resultado da soma " + num1 + " + " + num2 + " resulta " + soma);
            Console.ReadKey();

        }
    }
}
