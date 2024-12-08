using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excase_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string oper;

            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador de acordo com a tabela abaixo: \n+ = adição \n- = subtração \n* = multiplicação \n/ = divisão ");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    break;
            }
            Console.ReadKey();
        }
    }
}
