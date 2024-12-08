using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex46_filaprioridade
{
    class Program
    {
        static void Main(string[] args)
        {
            int nivel_prioritario;

            Console.WriteLine("DIGITE SEU NÍVEL DE PRIORIDADE:");
            Console.WriteLine("1 - IDOSO");
            Console.WriteLine("2 - GESTANTE");
            Console.WriteLine("3 - CADEIRANTE");
            Console.WriteLine("4 - SEM PRIORIDADES");
            nivel_prioritario = int.Parse(Console.ReadLine());
            
            if((nivel_prioritario==1) || (nivel_prioritario == 2) || (nivel_prioritario == 3))
            {
                Console.WriteLine("TEM PRIORIDADE NA FILA");
            }
            else if(nivel_prioritario == 4)
            {
                Console.WriteLine("NÃO TEM PRIORIDADE NA FILA");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido!");
            }

            Console.ReadKey();
        }
    }
}
