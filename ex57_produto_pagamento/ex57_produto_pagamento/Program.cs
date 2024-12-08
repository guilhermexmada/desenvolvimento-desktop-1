using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex57_produto_pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_prod, modo_pagar;

            Console.WriteLine("Digite o valor do produto: ");
            valor_prod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a forma de pagamento conforme a tabela: \nÀ vista = 1\n3 parcelas = 2\n+3 parcelas = 3");
            modo_pagar = int.Parse(Console.ReadLine());

            switch (modo_pagar)
            {
                case 1:
                    Console.WriteLine("Valor final com desconto de 10% = " + (valor_prod - (valor_prod * 0.1)));
                    break;
                case 2:
                    Console.WriteLine("Valor final com desconto de 5% = " + (valor_prod - (valor_prod * 0.05)));
                    break;
                case 3:
                    Console.WriteLine("Valor final sem desconto = " + valor_prod);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Forma de pagamento inválida. Tente novamente.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
