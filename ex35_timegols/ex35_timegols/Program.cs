using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex35_timegols
{
    class Program
    {
        static void Main(string[] args)
        {
            string team1, team2;
            int goals1, goals2;

            Console.WriteLine("Digite o nome do time de casa: ");
            team1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do time de fora: ");
            team2 = Console.ReadLine();
            Console.WriteLine("Digite o número de gols marcados pelo " + team1 + " : ");
            goals1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de gols marcados pelo " + team2 + " : ");
            goals2 = int.Parse(Console.ReadLine());

            if(goals1>goals2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(team1 + " venceu " + team2 + " ! ");
            }
            else if (goals1 == goals2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Empate");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(team2 + " venceu " + team1 + " ! ");
            }

            Console.ReadKey();
        }
    }
}
