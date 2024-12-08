using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex43_impostoderenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int num_dep;
            double renda_bruta, desc_dep, renda_liq, taxa;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o número de dependentes: ");
            num_dep = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua renda bruta: ");
            renda_bruta = double.Parse(Console.ReadLine());

            desc_dep = 600 * num_dep;
            renda_liq = renda_bruta - desc_dep;

            if (renda_liq <= 10000)
            {
                Console.WriteLine("Taxa de imposto: isento");
                Console.WriteLine("Desconto total: " + desc_dep);
                Console.WriteLine("Renda Líquida: " + renda_liq);
            }
            else if ((renda_liq >= 10000) && (renda_liq <= 30000))
            {
                Console.WriteLine("Taxa de imposto: 5%");
                Console.WriteLine("Desconto total: " + desc_dep);
                Console.WriteLine("Renda Líquida: " + (renda_liq + (renda_liq*0.05)));
            }
            else if ((renda_liq >= 30000) && (renda_liq <= 60000))
            {
                Console.WriteLine("Taxa de imposto: 10%");
                Console.WriteLine("Desconto total: " + desc_dep);
                Console.WriteLine("Renda Líquida: " + (renda_liq + (renda_liq * 0.1)));
            }
            else
            {
                Console.WriteLine("Taxa de imposto: 15%");
                Console.WriteLine("Desconto total: " + desc_dep);
                Console.WriteLine("Renda Líquida: " + (renda_liq + (renda_liq * 0.15)));
            }
            Console.ReadKey();
        }
    }
}
