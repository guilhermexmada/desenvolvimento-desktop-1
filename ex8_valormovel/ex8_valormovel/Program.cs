using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_valormovel
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, valor_parcel, taxa_juros;
            int quant_parcel;

            Console.WriteLine("Digite a quantidade de parcelas a ser pagas pelo móvel: ");
            quant_parcel = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada parcela: ");
            valor_parcel = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros sobre cada parcela: ");
            taxa_juros = double.Parse(Console.ReadLine());

            total = valor_parcel + (valor_parcel * (taxa_juros / 100) * quant_parcel);
            Console.WriteLine("O total a ser pago é de R$ " + total + ",00");

            Console.ReadKey();
        }
    }
}
