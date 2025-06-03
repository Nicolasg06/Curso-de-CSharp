using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "olá ".ToUpper().Insert(3, "World!").Replace("World!", " Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
           
            Console.WriteLine(valorImportante?.Length);
            // a interrogação impede que a leitura seja realizada caso o valor esta nulo(null)
        }
    }
}
