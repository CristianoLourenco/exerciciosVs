using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios17
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorA, valorB;
            Console.WriteLine("Informe o primeiro valor: ");
            valorA = Console.ReadLine();

            valorB = valorA;

            Console.WriteLine("Informe o segundo valor: ");
            valorB = Console.ReadLine();

            valorA = valorB;
            Console.WriteLine("Valor A: " + valorA + "  o valor B: " + valorB);
            Console.ReadKey();


        }
    }
}
