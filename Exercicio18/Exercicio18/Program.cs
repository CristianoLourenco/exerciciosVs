using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int celcius;
            int Fahrient;

            Console.WriteLine("Informe a temperatura em celcius: ");
            celcius = Convert.ToInt32(Console.ReadLine());
            Fahrient = (9 * celcius + 160) / 5;

            Console.WriteLine("A temperatura de: " + celcius + " graus celcius igual a: " + Fahrient + " graus em Farrient");


                
                
        }

    }
}
