using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Write("=============== Programa que calcula e exibe a idade =================\n" +
               "Escolha - 1 para calcular a idade \n" +
               "Escolha - 2 para sair do programa \n"
               );
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: apresentandoIdade();
                        break;
                    case 2: break;
                    default: Console.WriteLine("Opcao invalida");
                        break;
                }
            } while (opcao != 2);


        }
        static void apresentandoIdade()
        {
           
           

            string nome;
            int ano, mes, dia;
            DateTime dataActaual,nascimento;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("digite o dia do nascimento: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o mes do nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o ano do nascimento: ");
            ano = Convert.ToInt32(Console.ReadLine());

            dataActaual = DateTime.Now;
            nascimento = new DateTime(ano, mes, dia);

            // Utilizar dateTime para obter a idade e complicado, pois ela nao permite calculos,
            //ao inves disso podemos utilizar o TimeSpan que permite efectuar calculos com datas
            TimeSpan result = dataActaual - nascimento;
            int idade = result.Days / 30 / 12;

            Console.WriteLine("O " + nome + " tem " + idade.ToString() + " anos de idade");
            
        }
    }
}
