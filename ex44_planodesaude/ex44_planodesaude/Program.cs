using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex44_planodesaude
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 10)
            {
                Console.WriteLine("O preço do seu plano de saúde é de R$ 30,00");
            }
            else if ((idade >= 10) && (idade <= 29))
            {
                Console.WriteLine("O preço do seu plano de saúde é de R$ 60,00");
            }
            else if ((idade >= 29) && (idade <= 45))
            {
                Console.WriteLine("O preço do seu plano de saúde é de R$ 120,00");
            }
            else if ((idade >= 45) && (idade <= 59))
            {
                Console.WriteLine("O preço do seu plano de saúde é de R$ 150,00");
            }
            Console.ReadKey();
        }
    }
}
