using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            verificandoIgualdade();
        }
        static void verificandoIgualdade()
        {
            int primeiroNumero;
            int segundoNumero;

            Console.WriteLine("============= Programa que verifica a igualdade entre dois numeros ================== \n");

            Console.WriteLine("Digite o primerio numero: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero == segundoNumero)
                Console.WriteLine("Os dois numeros sao Iguais");
            else
                Console.WriteLine("Os dois numeros nao sao iguais");

        }
    }
}
