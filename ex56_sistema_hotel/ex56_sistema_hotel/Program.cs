using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex56_sistema_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int mensagem_recepcao;
            string pedido;

            Console.WriteLine("Digite o número de sua ação de acordo com a tabela: \nFazer check-in = 1\nChamar serviço de quarto = 2\nFazer pedido = 3");
            mensagem_recepcao = int.Parse(Console.ReadLine());
            switch (mensagem_recepcao)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Check-in feito!");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Chamando serviço de quarto...");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite seu pedido: ");
                    pedido = Console.ReadLine();
                    Console.WriteLine("Pedido enviado!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Erro de digitação");
                    break;
            }
            Console.ReadKey();
        }
    }
}
