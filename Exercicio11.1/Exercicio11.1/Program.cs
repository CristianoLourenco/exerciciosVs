using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1 & numero <= 12 & numero != 8 & numero != 9)
            {
                Console.WriteLine("O numero esta entre 1 a 12 e [e] diferente de 8 e 9");

            }
            else
            {
                Console.WriteLine("O numero nao esta entre 1 a 12 ou [e] igual a 8 e 9");

            }
        }
    }
}
