using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex53_peso_gravidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso, planeta;

            Console.WriteLine("Digite seu peso em número inteiro aproximado: ");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número de acordo com a tabela: \nMercúrio = 1\nVênus = 2\nMarte = 3\nJúpiter = 4\nSaturno = 5 ");
            planeta = int.Parse(Console.ReadLine());
            
            switch (planeta)
            {
                case 1:
                    Console.WriteLine("Seu peso em Mercúrio é de " + peso * 0.37);
                    break;
                case 2:
                    Console.WriteLine("Seu peso em Vênus é de " + peso * 0.88);
                    break;
                case 3:
                    Console.WriteLine("Seu peso em Marte é de " + peso * 0.38);
                    break;
                case 4:
                    Console.WriteLine("Seu peso em Júpiter é de " + peso * 2.64);
                    break;
                case 5:
                    Console.WriteLine("Seu peso em Saturno é de " + peso * 1.15);
                    break;
                default:
                    Console.WriteLine("Número fora do intervalo estabelecido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
