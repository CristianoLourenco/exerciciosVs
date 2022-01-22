using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        //verificando se os nomes sao iguais
        static void Main(string[] args)
        {
            string primeiroNome, segundoNome, terceiroNome;
            Console.WriteLine("Digite o primeiro nome: ");
            primeiroNome = Console.ReadLine();

            Console.WriteLine("Digite o segundo nome: ");
            segundoNome = Console.ReadLine();

            Console.WriteLine("Digite o terceiro nome: ");
            terceiroNome = Console.ReadLine();

            if (primeiroNome == segundoNome & segundoNome == terceiroNome)
            {
                Console.WriteLine("Os nomes sao iguais ");
            }
            else
            {
                Console.WriteLine("os nomes sao diferentes: ");
            }
        }
    }
}
