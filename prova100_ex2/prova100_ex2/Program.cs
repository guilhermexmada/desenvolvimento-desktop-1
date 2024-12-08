using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova100_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double vel;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a velocidade na qual você dirige: ");
            vel = double.Parse(Console.ReadLine());
            if((vel >= 10) && (vel <= 45))
            {
                Console.WriteLine(nome + ", você está abaixo da velocidade máxima permitida.");
            } 
            else if((vel >= 46 )&&(vel <= 65)){
                Console.WriteLine(nome + ", você está na velocidade máxima permitida.");
            }
            else if((vel >= 66)&&(vel <= 75))
            {
                Console.WriteLine(nome + ", você está passando da velocidade máxima permitida.");
            }
            else if (vel > 75)
            {
                Console.WriteLine(nome + ", você está acima da velocidade máxima permitida.");
            }
            else
            {
                Console.WriteLine(nome + ", você está abaixo da velocidade máxima permitida.");
            }
            Console.ReadKey();
        }
    }
}
