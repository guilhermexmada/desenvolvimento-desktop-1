using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17_lojaroupas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_venda, sal_total;

            Console.WriteLine("Digite o valor total de vendas no mês: ");
            valor_venda = double.Parse(Console.ReadLine());

            sal_total = valor_venda + 1200 + (valor_venda * 0.15);
            Console.WriteLine("Seu salário final é de R$ " + sal_total + ",00");
            Console.ReadKey();
        }
    }
}
