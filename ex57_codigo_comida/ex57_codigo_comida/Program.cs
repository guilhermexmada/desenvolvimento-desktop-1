using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex57_codigo_comida
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quant;

            Console.WriteLine("Digite o código de sua refeição de acordo com a tabela abaixo: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("100 - CACHORRO QUENTE - R$ 1,70\n101 - BAURU SIMPLES - R$2,30\n102 - BAURU COM OVO - R$ 2,60");
            Console.WriteLine("103 - HAMBÚRGUER - R$ 2,40\n104 - CHEESEBURGUER - R$ 2,50\n105 - REFRIGERANTE - R$ 1,00");
            codigo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a quantidade da refeição: ");
            quant = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 100:
                    Console.WriteLine("Valor total = " + (quant * 1.70));
                    break;
                case 101:
                    Console.WriteLine("Valor total = " + (quant * 2.30));
                    break;
                case 102:
                    Console.WriteLine("Valor total = " + (quant * 2.60));
                    break;
                case 103:
                    Console.WriteLine("Valor total = " + (quant * 2.40));
                    break;
                case 104:
                    Console.WriteLine("Valor total = " + (quant * 2.50));
                    break;
                case 105:
                    Console.WriteLine("Valor total = " + (quant * 1.00));
                    break;
            }
            Console.ReadKey();
        }
    }
}
