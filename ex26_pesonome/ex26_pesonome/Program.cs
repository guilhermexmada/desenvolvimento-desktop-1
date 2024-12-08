using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex26_pesonome
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2;
            double p1, p2;

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            n1 = Console.ReadLine();
            Console.WriteLine("Digite seu peso em kg, " + n1 + " : ");
            p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            n2 = Console.ReadLine();
            Console.WriteLine("Digite seu peso em kg, " + n2 + " : ");
            p2 = double.Parse(Console.ReadLine());

            if (p1 > p2)
            {
                Console.WriteLine(n1 + "(" + p1 + "kg) é mais pesado que " + n2 + "(" + p2 + "kg)");
            }
            else if (p1 == p2)
            {
                Console.WriteLine(n1 + " e " + n2 + " têm o mesmo peso (" + p1 + "kg)");
            }
            else
            {
                Console.WriteLine(n2 + "(" + p2 + "kg) é mais pesado que " + n1 + "(" + p1 + "kg)");
            }
            Console.ReadKey();
        }
    }
}
