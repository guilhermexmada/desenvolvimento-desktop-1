using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex54_trimestres_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes_nasc;

            Console.WriteLine("Digite seu mês de nascimento: ");
            mes_nasc = Console.ReadLine();

            switch (mes_nasc)
            {
                case "janeiro":
                case "fevereiro":
                case "março":
                    Console.WriteLine("Você nasceu no primeiro trimestre");
                    break;
                case "abril":
                case "maio":
                case "junho":
                    Console.WriteLine("Você nasceu no segundo trimestre");
                    break;
                case "julho":
                case "agosto":
                case "setembro":
                    Console.WriteLine("Você nasceu no terceiro trimestre");
                    break;
                case "outubro":
                case "novembro":
                case "dezembro":
                    Console.WriteLine("Você nasceu no quarto trimestre");
                    break;
            }
            Console.ReadKey();
        }
    }
}
