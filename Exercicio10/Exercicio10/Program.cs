using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");

            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero e par");

            }
            else
            {
                Console.WriteLine("O numero e impar");

            }

        }
    }
}
