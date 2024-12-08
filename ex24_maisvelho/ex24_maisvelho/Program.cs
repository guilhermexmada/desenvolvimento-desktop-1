using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex24_maisvelho
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_1, nome_2;
            int idade_1, idade_2;

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            nome_1 = Console.ReadLine();
            Console.WriteLine(nome_1 + ", digite sua idade: ");
            idade_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            nome_2 = Console.ReadLine();
            Console.WriteLine(nome_2 + ", digite sua idade: ");
            idade_2 = int.Parse(Console.ReadLine());

            if (idade_1 > idade_2)
            {
                Console.WriteLine(nome_1 + " é mais velho que " + nome_2);
            }
            else if (idade_1 == idade_2)
            {
                Console.WriteLine(nome_1 + " e " + nome_2 + " têm a mesma idade");
            }
            else
            {
                Console.WriteLine(nome_2 + " é mais velho que " + nome_1);
            }


            Console.ReadKey();
        }
    }
}
