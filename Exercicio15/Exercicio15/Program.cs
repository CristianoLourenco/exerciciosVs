using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
  
    class Program
    {
 
        static void Main(string[] args)
        {
            int opcao;
            
            int votoSHaban = 0;
            int votoCirilo = 0;

            do
            {
                Console.Write("========= Programa de votos ===========" +
                   "Digite 1 para votar no Shaban \n" +
                   "Digite 2 para votar no Meneses Cirilo \n" +
                   "Digite 3 para comparar os votos e eleger o vencedor \n" +
                   "Digite 4 para sair \n"
                             );
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1 : votoSHaban = votoGeral(votoSHaban, "Shaban");  break;
                    case 2 : votoCirilo = votoGeral(votoCirilo, "Cirilo"); break;
                    case 3 : comparar(votoSHaban, votoCirilo); break;


                    default:
                        break;
                }

            } while (opcao !=3);
            

        }
        static int votoGeral( int voto, string nome)
        {
            if (voto >= 2)
            {
                Console.WriteLine("\n Votacao lotada \n com: " + voto.ToString() + " votos no total para: " + nome);
            }
            else
            {
                Console.WriteLine("Voto para o " + nome);
                voto = voto + 1;
                Console.WriteLine("\n");

            }
            return voto;
        }
        static void comparar(int candidato1, int candidato2)
        {
            if (candidato1 == candidato2)
            {
                Console.WriteLine("Empataram");
            }
            else
            if (candidato1 > candidato2)
            {
                Console.WriteLine("Candidato 1 [e] o vencedor");
            }
            else
            {
                Console.WriteLine("Candidato 2 [e] o vencedor");
            }
        }
    }
}
