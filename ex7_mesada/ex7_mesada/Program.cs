using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_mesada
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, mesada;
           
            Console.WriteLine("Você tem R$ 400,00 no cofre \nDigite o valor da mesada: ");
            mesada = double.Parse(Console.ReadLine());

            total = mesada + 400;
            Console.WriteLine("Ao total você tem R$ " + total + ",00");

            Console.ReadKey();

        }
    }
}
