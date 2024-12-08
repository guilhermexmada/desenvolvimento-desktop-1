using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_velocidade
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, time, velocity;

            Console.WriteLine("Digite a distância percorrida pelo projétil em quilômetros: ");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo gasto pelo projétil em mintuos: ");
            time = double.Parse(Console.ReadLine());

            velocity = (distancia * 1000) / (time * 60);
            Console.WriteLine("A velocidade do projétil é de " + velocity + " m/s");

            Console.ReadKey();
        }
    }
}
