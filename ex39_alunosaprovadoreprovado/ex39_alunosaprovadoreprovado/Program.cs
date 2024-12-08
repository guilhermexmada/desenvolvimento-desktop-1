using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex39_alunosaprovadoreprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double m1, m2;

            Console.WriteLine("Digite seu nome, aluno 1: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite sua média, " + nome1 + " : ");
            m1 = double.Parse(Console.ReadLine());

            if (m1<4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADO: E");
            }
            else if((m1 >= 4) && (m1 <6))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADO: D");
            }
            else if((m1 >=6) && (m1 <7.5))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("APROVADO: C");
            }
            else if((m1>=7.5) && (m1<9))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROVADO: B");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROVADO: A");
            }

            Console.WriteLine("Digite seu nome, aluno 2: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite sua média, " + nome2 + " : ");
            m2 = double.Parse(Console.ReadLine());

            if (m2 < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADO: E");
            }
            else if ((m2 >= 4) && (m2 < 6))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADO: D");
            }
            else if ((m2 >= 6) && (m2 < 7.5))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("APROVADO: C");
            }
            else if ((m2 >= 7.5) && (m2 < 9))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROVADO: B");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROVADO: A");
            }


            Console.ReadKey();

        }
    }
}
