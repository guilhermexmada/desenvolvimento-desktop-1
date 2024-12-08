using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAÇÃO DE VARIÁVEL INTEIRA
            int num1, mult;
            //COMANDO ESCREVA
            Console.WriteLine("Digite um número: ");
            //COMANDO LEIA (int.Parse = converte para inteiro)
            num1 = int.Parse (Console.ReadLine());
            //CÁLCULO
            mult = num1 * 3;
            //COMANDO ESCREVA MOSTRANDO VARIÁVEL
            Console.WriteLine("O número " + num1 + " multiplicado por 3 dá: " + mult);
            //COMANDO PRA NÃO FECHAR TELA
            Console.ReadKey();





        }
    }
}
