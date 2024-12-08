using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cores
{
    class Program
    {
        static void Main(string[] args)
        {
            string corfundo, cortext;
            Console.WriteLine("Cores disponíveis = RED, GREEN, BLUE, YELLOW, GRAY");
            Console.WriteLine("Digite a cor do texto em inglês: ");
            cortext = Console.ReadLine();

            if ((cortext == "RED") || (cortext == "red") || (cortext == "Red"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Agora o texto está em vermelho!");
            }
            else if ((cortext == "GREEN") || (cortext == "green") || (cortext == "Green"))
                    {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Agora o texto está em verde!");
            }

            else if ((cortext == "BLUE") || (cortext == "blue") || (cortext == "Blue"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Agora o texto está em azul!");
            }

            else if ((cortext == "YELLOW") || (cortext == "yellow") || (cortext == "Yellow"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Agora o texto está em amarelo!");
            }

            else if ((cortext == "Gray") || (cortext == "gray") || (cortext == "GRAY"))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Agora o texto está em cinza!");
            }
            Console.ReadKey();
        }
    }
}
