using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex49_switchcase_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia_semana;

            Console.WriteLine("Digite o número do dia da semana:");
            dia_semana = int.Parse(Console.ReadLine());

            switch (dia_semana)
            {
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;

                case 3:
                    Console.WriteLine("Terça-feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;

                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;

                case 1:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("Dia da semana inválido");
                    break;

            }
            Console.ReadKey();
        }
    }
}
