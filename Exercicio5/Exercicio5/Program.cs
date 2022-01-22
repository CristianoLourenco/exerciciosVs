using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Write("=============== Programa que calcular e exibe a data de nascimento =================\n" +
               "Escolha - 1 para calcular nascimento \n" +
               "Escolha - 2 para sair do programa \n"
               );
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: pegandoAnoNascimento();
                        break;
                    case 2: break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            } while (opcao != 2);
         

        }

        static void pegandoAnoNascimento()
        {
            string nome;
            int idade;
            DateTime dataAtual;
            int resultado;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            dataAtual = new DateTime();
            dataAtual = DateTime.Now;

            resultado = dataAtual.Year - idade;


            Console.WriteLine("O " + nome + " nasceu em: " + resultado.ToString());





        }
    }
}
