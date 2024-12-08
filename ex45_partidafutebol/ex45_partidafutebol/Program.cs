using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex45_partidafutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            int publico;

            Console.WriteLine("Digite a quantidade de pessoas que assistiram à partida: ");
            publico = int.Parse(Console.ReadLine());
            
            if((publico >= 100) && (publico <= 1000))
            {
                Console.WriteLine("Arquibancada vazia");
            }

            else if((publico >= 1001) && (publico <=15000))
            {
                Console.WriteLine("Arquibancada média");
            }
            else
            {
                Console.WriteLine("Arquibancada lotada");
            }


            Console.ReadLine();
        }
    }
}
