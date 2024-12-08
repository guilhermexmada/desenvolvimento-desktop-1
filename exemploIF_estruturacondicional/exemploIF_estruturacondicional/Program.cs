using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploIF_estruturacondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota_1, nota_2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota_2 = double.Parse(Console.ReadLine());
            media = (nota_1 + nota_2) / 2;
            
            //ESTRUTURA CONDICIONAL//
            
            if(media>6)
            {
                Console.WriteLine("Parabéns! Você foi aprovado(a).");
            }

            else if (media == 6)
            {
                Console.WriteLine("Favor aguardar. Você será encaminhado(a) para exame.");
            }

            else
            {
                Console.WriteLine("Infelizmente você foi reprovado(a).");
            }

            
            Console.ReadKey();
        }
    }
}
