using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            //comando escreva
            Console.WriteLine("Digite o primeiro número: ");
            //comando leia
            num1 = int.Parse(Console.ReadLine());
            //comando escreva
            Console.WriteLine("Digite o segundo número: ");
            //comando leia
            num2 = int.Parse(Console.ReadLine());
            //cálculo
            soma = num1 + num2;
            //comando escreva
            Console.WriteLine(num1 + " + " + num2 + " = " + soma);
            //comando pra não fechar console ou tela de execução
            Console.ReadKey();
        }
    }
}
