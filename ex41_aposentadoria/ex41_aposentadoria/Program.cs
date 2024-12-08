using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex41_aposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, ano_nasc, ano_ing, ano_atual, idade, tempo_trab;

            Console.WriteLine("Digite seu código de empregado: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu ano de nascimento: ");
            ano_nasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu ano de ingresso na firma: ");
            ano_ing = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());

            idade = ano_atual - ano_nasc;
            tempo_trab = ano_atual - ano_ing;

            if ((idade >= 65) || (tempo_trab >= 30) || ((idade >= 60) && (tempo_trab >= 25)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Apto para aposentadoria");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não requer aposentadoria");
            }
            Console.ReadKey();
        }
    }
}
