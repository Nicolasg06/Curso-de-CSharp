using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;// and operador "i" se caso os dois forem verdadeiros o resultado sera verdadeiro
            Console.WriteLine("Comprou a Tv de 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;// or operador "ou" se caso um ou outro for verdadeiro o resultado sera verdadeiro, se for falso falso, resultado falso
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;// xor operador "ou exclusivo" um ou outro tem que ser verdadeiro ou falso, ver e ver fal e fal, o resultado é falso 
            Console.WriteLine("Comprou Tv de 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
        }
    }
}
