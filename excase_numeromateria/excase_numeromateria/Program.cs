using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excase_numeromateria
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int num_matricula, num_materia;

            Console.WriteLine("Digite seu nome, aluno : ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o número de sua matrícula, " + nome + " : ");
            num_matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu número de matéria de acordo com a tabela abaixo: \n\n1 = matemática \n2 = linguagem de programação \n3 = português");
            Console.WriteLine("4 = inglês");
            num_materia = int.Parse(Console.ReadLine());

            switch (num_materia){
                case 1:
                    Console.WriteLine(nome + ", você está estudando matemática e seu número de matrícula é " + num_matricula);
                    break;
                case 2:
                    Console.WriteLine(nome + ", você está estudando linguagem de programação e seu número de matrícula é " + num_matricula);
                    break;
                case 3:
                    Console.WriteLine(nome + ", você está estudando português e seu número de matrícula é " + num_matricula);
                    break;
                case 4:
                    Console.WriteLine(nome + ", você está estudando inglês e seu número de matrícula é " + num_matricula);
                    break;
                default:
                    Console.WriteLine("número de matéria inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
