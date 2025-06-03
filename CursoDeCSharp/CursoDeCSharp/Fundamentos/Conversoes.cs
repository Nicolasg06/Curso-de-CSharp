using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;//cach , converte o valor perdendo informação 
            Console.WriteLine("nota truncada:{0}",notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}",idadeInteiro);

            Console.Write("digite um numero: ");
            string palavra= Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);// tryParse permite que se o usuario forneça dados incorretos(letra no lugar de numero), o programa prenche com 0 e continua rodando
            Console.WriteLine(numero);

            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);
        }
    }
}
