using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex42_salarioliquido
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_hora, sal_bruto, sal_liq_fiveper, sal_liq_sevenper, sal_liq_tenper;
            int horas_mens;

            Console.WriteLine("Digite o valor da sua hora trabalhada: ");
            valor_hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite as suas horas trabalhadas nesse mês: ");
            horas_mens = int.Parse(Console.ReadLine());

            sal_bruto = horas_mens * valor_hora;
            sal_liq_fiveper = sal_bruto - (sal_bruto * 5) / 100;
            sal_liq_sevenper = sal_bruto - (sal_bruto * 7) / 100;
            sal_liq_tenper = sal_bruto - (sal_bruto * 10) / 100;

            if (sal_bruto <= 1000)
            {
                Console.WriteLine("Seu salário líquido é de R$ " + sal_liq_fiveper + ",00");
            }
            else if ((sal_bruto >= 1000) && (sal_bruto <= 4000))
            {
                Console.WriteLine("Seu salário líquido é de R$ " + sal_liq_sevenper + ",00");
            }
            else if (sal_bruto > 4000)
            {
                Console.WriteLine("Seu salário líquido é de R$ " + sal_liq_tenper + ",00");
            }

            Console.ReadKey();
        }
    }
}
