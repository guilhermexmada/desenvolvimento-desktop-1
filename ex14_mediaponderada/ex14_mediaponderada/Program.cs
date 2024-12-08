using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_mediaponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, t1, t2, list, media;

            Console.WriteLine("Digite a nota da prova 1 : ");
            p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova 2 : ");
            p2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do trabalho 1 : ");
            t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do trabalho 2 : ");
            t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da lista de exercícios : ");
            list = double.Parse(Console.ReadLine());

            media = (((p1+p2)*0.6)+((t1+t2)*0.3)+(list*0.1)/1.0);

            Console.WriteLine("A média final é " + media);

            Console.ReadKey();

        }

    }
}
