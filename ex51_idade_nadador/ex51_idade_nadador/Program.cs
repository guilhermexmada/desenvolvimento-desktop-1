using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex51_idade_nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite a sua idade, nadador: ");
            idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Infantil A");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Infantil B");
                    break;
                case 12:
                case 13:
                    Console.WriteLine("Juvenil A");
                    break;
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Juvenil B");
                    break;
                default:
                    Console.WriteLine("Adulto");
                    break;
            }
            Console.ReadKey();


        }
    }
}
