using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.EstruturasDeControle
{
     class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random randon = new Random();

            int numeroSecreto = randon.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
               
                tentativas++;
                tentativasRestantes--;
               
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nuemro encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Tente um número menor...");
                    Console.WriteLine("Tentativas Restantes {0} ", tentativasRestantes);
                }
                else 
                {
                    Console.WriteLine("Tente um número maior...");
                    Console.WriteLine("Tentativas restantes {0} ", tentativasRestantes);
                }
                

            }
        }
    }
}
