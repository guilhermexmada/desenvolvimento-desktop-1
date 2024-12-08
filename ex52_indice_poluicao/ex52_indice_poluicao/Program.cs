using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex52_indice_poluicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;

            Console.WriteLine("Digite um número inteiro para o índice de poluição da indústria: ");
            indice = int.Parse(Console.ReadLine());

            switch (indice)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Nível de poluição aceitável");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Suspender atividades do grupo 1 de 3");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Suspender atividades dos grupos 1 e 2 de 3");
                    break;
                default:
                    Console.WriteLine("Suspender atividades dos 3 grupos");
                    break;
            }
            Console.ReadKey();
        }
    }
}
