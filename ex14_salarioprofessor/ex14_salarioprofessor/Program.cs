using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_salarioprofessor
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal_bruto, sal_liq, valor_hora, horas_trabalhadas, percentual_INSS;

            Console.WriteLine("Professor, digite quantas horas foram trabalhadas: ");
            horas_trabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada hora aula: ");
            valor_hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de desconto cobrado pelo INSS: ");
            percentual_INSS = double.Parse(Console.ReadLine());

            sal_bruto = horas_trabalhadas * valor_hora;
            sal_liq = sal_bruto - (sal_bruto * percentual_INSS / 100);
            Console.WriteLine("O seu salário líquido é de R$ " + sal_liq);

            Console.ReadKey();


        }
    }
}
