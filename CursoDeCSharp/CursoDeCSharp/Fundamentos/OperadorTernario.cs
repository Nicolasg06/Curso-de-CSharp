using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 10.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado " : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
