using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex30_publicoshow
{
    class Program
    {
        static void Main(string[] args)
        {
            int publico;

            Console.WriteLine("Digite a quantidade de pessoas que assistiram ao show: ");
            publico = int.Parse(Console.ReadLine());

            if (publico > 400)
            {
                Console.WriteLine("Show lotado!");
            }
            else if (publico == 400)
            {
                Console.WriteLine("Público bom");
            }
            else
            {
                Console.WriteLine("Público baixo");
            }

            Console.ReadKey();
        }
    }
}
