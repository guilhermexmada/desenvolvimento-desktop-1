using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex25_mediasalunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno_1, aluno_2;
            double n1_1, n2_1, n3_1 , n1_2, n2_2, n3_2, media_1, media_2;

            Console.WriteLine("Digite o nome do primeiro aluno: ");
            aluno_1 = Console.ReadLine();
            Console.WriteLine(aluno_1 + ", digite sua primeira nota: ");
            n1_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota: ");
            n2_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota: ");
            n3_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo aluno: ");
            aluno_2 = Console.ReadLine();
            Console.WriteLine(aluno_2 + ", digite sua primeira nota: ");
            n1_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota: ");
            n2_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota: ");
            n3_2 = double.Parse(Console.ReadLine());

            media_1 = (n1_1 + n2_1 + n3_1) / 3;
            media_2 = (n1_2 + n2_2 + n3_2) / 3;

            if (media_1 > media_2)
            {
                Console.WriteLine(aluno_1 + " tem uma média maior que " + aluno_2);
            }
            else if (media_1 == media_2)
            {
                Console.WriteLine(aluno_1 + " e " + aluno_2 + " têm a mesma média");
            }
            else
            {
                Console.WriteLine(aluno_2 + " tem uma média maior que " + aluno_1);
            }

            Console.ReadKey();

        }
    }
}
