using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16_produtodesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quant;
            double precounit, valortot, valordesc;

            Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade comprada de " + nome + " : ");
            quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário de " + nome + " : ");
            precounit = double.Parse(Console.ReadLine());

            valortot = precounit * quant;
            Console.WriteLine("O valor total da compra sem desconto é de R$ " + valortot + ",00");

            valordesc = valortot - (valortot * 0.03);
            Console.WriteLine("O valor total da compra com desconto é de R$ " + valordesc + ",00");


            Console.ReadKey();

        }
    }
}
