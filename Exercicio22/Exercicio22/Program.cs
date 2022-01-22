using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            int multiplo = 0;
            while (multiplo < 9)
            {
                Console.WriteLine(nome);
                multiplo++;
            }
        }
    }
}
