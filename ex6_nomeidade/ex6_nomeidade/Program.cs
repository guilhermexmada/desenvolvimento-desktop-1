using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_nomeidade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int ano_nascimento, ano_atual, idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu ano de nasicmento: ");
            ano_nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());

            idade = ano_atual - ano_nascimento;
            Console.WriteLine("Sua idade é: " + idade);

            Console.ReadKey();


        }
    }
}
