using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            programaElementardeDoisNumeros();
       

           

        }
        static void programaElementardeDoisNumeros()
        {
            int segundoNumero;
            int primeiroNumero;
            int soma;
            int subtracao;
            int multiplicacao;
            double divisao;


            Console.WriteLine("Introduza o primeiro numero: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Introduza o segundo nuemero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            soma = primeiroNumero + segundoNumero;

            subtracao = primeiroNumero - segundoNumero;

            multiplicacao = primeiroNumero * segundoNumero;

            divisao = (Convert.ToDouble(primeiroNumero) / Convert.ToDouble(segundoNumero));


            Console.WriteLine("A soma entre os dois: " + soma.ToString());
            Console.WriteLine("A suntracao entre os dois: " + subtracao.ToString());
            Console.WriteLine("A Multiplicacao entre os dois: " + multiplicacao.ToString());
            Console.WriteLine("A divisao entre os dois: " + divisao.ToString());
        }
    }
}
