using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12_tresprodutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_1, nome_2, nome_3;
            int quant_1, quant_2, quant_3;
            double valorunit_1, valorunit_2, valorunit_3, valortot_1, valortot_2, valortot_3, valortotfinal;

            Console.WriteLine("Digite o nome do primeiro produto: ");
            nome_1 = Console.ReadLine();
            Console.WriteLine("Digite o valor unitário de " + nome_1 + " : ");
            valorunit_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade comprada de " + nome_1 + " : ");
            quant_1 = int.Parse(Console.ReadLine());
            valortot_1 = quant_1 * valorunit_1;
            Console.WriteLine("O valor total de " + quant_1 + " unidades de " + nome_1 + " é de R$ " + valortot_1 + ",00 \n"); 

            Console.WriteLine("Digite o nome do segundo produto: ");
            nome_2 = Console.ReadLine();
            Console.WriteLine("Digite o valor unitário de " + nome_2 + " : ");
            valorunit_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade comprada de " + nome_2 + " : ");
            quant_2 = int.Parse(Console.ReadLine());
            valortot_2 = quant_2 * valorunit_2;
            Console.WriteLine("O valor total de " + quant_2 + " unidades de " + nome_2 + " é de R$ " + valortot_2 + ",00 \n");

            Console.WriteLine("Digite o nome do terceiro produto: ");
            nome_3 = Console.ReadLine();
            Console.WriteLine("Digite o valor unitário de " + nome_3 + " : ");
            valorunit_3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade comprada de " + nome_3 + " : ");
            quant_3 = int.Parse(Console.ReadLine());
            valortot_3 = quant_3 * valorunit_3;
            Console.WriteLine("O valor total de " + quant_3 + " unidades de " + nome_3 + " é de R$ " + valortot_3 + ",00 \n");
            valortotfinal = valortot_1 + valortot_2 + valortot_3;
            Console.WriteLine("O valor total das três compras é de R$ " + valortotfinal + ",00");
            Console.ReadKey();

        }
    }
}
