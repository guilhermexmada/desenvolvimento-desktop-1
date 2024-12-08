using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex55_conta_agua
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumo_anterior, consumo_atual, consumo, tarifa;

            Console.WriteLine("Digite o consumo de água do mês atual em número inteiro do hidrômetro: ");
            consumo_atual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o consumo de água do mês anterior em número inteiro do hidrômetro: ");
            consumo_anterior = int.Parse(Console.ReadLine());
            consumo = consumo_atual - consumo_anterior;
            
            switch (consumo)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("O valor da conta é de R$ " + (consumo + (consumo * 0.69)));
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("O valor da conta é de R$ " + (consumo + (consumo * 1.17)));
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("O valor da conta é de R$ " + (consumo + (consumo * 1.48)));
                    break;
                default:
                    Console.WriteLine("O valor da conta é de R$ " + (consumo + (consumo * 1.60)));
                    break;
            }

            Console.ReadKey();
        }
    }
}
