using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine($"O valor de i É {i}");

            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamnho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i<= tamanhoTurma; i++) {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notAtual);

                somatorio += notAtual; 
            }
            double media = tamanhoTurma  > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);
        }
    }
}
