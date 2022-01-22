using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero;

            Console.WriteLine("digite o primeiro numero: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numro: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if ((primeiroNumero > segundoNumero) & (segundoNumero > primeiroNumero ))
            {
                Console.WriteLine("Os dois nuemros sao diferentes");
            }
            else
                Console.WriteLine("os dois numeros sao iguais");


        }
    }
}
