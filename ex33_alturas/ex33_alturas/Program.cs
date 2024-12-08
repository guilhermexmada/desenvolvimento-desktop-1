using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex33_alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2;
            double height1, height2;

            Console.WriteLine("Digite seu nome, usuário 1: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Digite sua altura, " + name1 + " : ");
            height1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome, usuário 2: ");
            name2 = Console.ReadLine();
            Console.WriteLine("Digite sua altura, " + name2 + " : ");
            height2 = double.Parse(Console.ReadLine());

            if (height1 > height2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(name1 + " é mais alto que " + name2);
            }
            else if (height2 > height1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(name2 + " é mais alto que " + name1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(name1 + " e " + name2 + " têm a mesma altura ");
            }


            Console.ReadKey();

        }
    }
}
