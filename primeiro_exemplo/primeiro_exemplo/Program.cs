using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAÇÃO DE VARIÁVEL STRING = CARACTER
            string nome;
            //COMANDO ESCREVA
            Console.WriteLine("Digite o seu nome: ");
            //COMANDO LEIA
            nome = Console.ReadLine();
            //COMANDO ESCREVA MOSTRA MENSAGEM
            Console.WriteLine("Bem vindo ao C# " + nome + " :)");
            //COMANDO PARA NÃO FECHAR TELA 
            Console.ReadKey()
        }
    }
}
