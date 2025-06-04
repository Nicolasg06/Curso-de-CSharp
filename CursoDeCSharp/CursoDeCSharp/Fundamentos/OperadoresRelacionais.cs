using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.WriteLine("Insira sua nota: ");
            double nota = double.Parse (Console.ReadLine());
            double notaDeCorte = 7.0;
            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 00.0);
            Console.WriteLine("Perfeito! {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("passou por media? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota< notaDeCorte);
            Console.WriteLine("Rprovado? {0}", nota<=3.0 );

        }
    }

}
