using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex21_voto16anos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int ano_nasc, ano_atual, idade, anos_falt;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu ano de nascimento: ");
            ano_nasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_nasc;
            anos_falt = 16 - idade;

            if(idade>=16)
            {
                Console.WriteLine(nome + ", você está apto à votar nas próximas eleições.");
            }
            else
            {
                Console.WriteLine(nome + ", ainda faltam " + anos_falt + " anos para que você participe do processo eleitoral.");
            }

            Console.ReadKey();

        }
    }
}
