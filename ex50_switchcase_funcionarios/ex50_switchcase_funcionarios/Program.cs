using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex50_switchcase_funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoria;
            double sal;

            Console.WriteLine("Digite sua categoria de funcionário (A, B ou C) : ");
            categoria = Console.ReadLine();
            Console.WriteLine("Digite seu salário atual: ");
            sal = double.Parse(Console.ReadLine());

            switch (categoria)
            {
                case "a":
                    Console.WriteLine("Seu novo salário é de " + (sal + (sal * 0.1)));
                    break;

                case "A":
                    Console.WriteLine("Seu novo salário é de " + (sal + (sal * 0.1)));
                    break;

                case "b":
                    Console.WriteLine("Seu novo salário é de " + (sal + (sal * 0.15)));
                    break;

                case "B":
                    Console.WriteLine("Seu novo salário é de " + (sal + (sal * 0.15)));
                    break;
                case "c":
                    Console.WriteLine("Seu novo salário é de " + (sal + (sal * 0.25)));
                    break;

                case "C":
                    Console.WriteLine("Seu novo salário é de " + (sal + (sal * 0.25)));
                    break;

                default:
                    Console.WriteLine("Sem aumento de salário");
                    break;

            }
                    Console.ReadKey();
        }
    }
}
