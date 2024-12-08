using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex36_parouimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número para que eu verifique se é ou não é par: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Este número é PAR");      
             }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este número é ÍMPAR");
            }
            Console.ReadKey();
        }
    }
}
