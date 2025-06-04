using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var boleano = true;

            Console.WriteLine(-valorNegativo);// inverte o valor do numero
            Console.WriteLine(!boleano);// negação, inverte o resultado de verdadeiro para falso e vice versa

            num1++;
            Console.WriteLine(num1); 
            --num2;
            Console.WriteLine(num2);// sinal antes da variavel tem um processo mais rapido  
        }
    }
}
