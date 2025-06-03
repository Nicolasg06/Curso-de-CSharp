using System;
using System.Globalization;

namespace CursoDeCSharp.Fundamentos
{
  class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// formata a quantidade de casas decimais 
            Console.WriteLine(valor.ToString("c"));// valor monetario
            Console.WriteLine(valor.ToString("P"));// porcentagem e multiplica por 100
            Console.WriteLine(valor.ToString("#.##"));//formata a quantidade de casas decimais 

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("c3", cultura));//valor de cultura, da uma formatação de acordo com o globalização solicitada/c3 formata a quantidade de casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("d10"));//insere "0" ao lado esquerdo 
        }
    }
}
