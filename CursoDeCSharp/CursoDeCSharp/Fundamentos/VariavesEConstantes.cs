using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.Fundamentos
{
    class VariavesEConstantes
    {
        public static void Executar()
        {
            //variavel pode ser alterada
            double raio = 4.5;

            //variavel nao pode ser alterada const
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine("esta chovedo? " + estaChovendo);

            byte idade = 45; //vai de 0 a 256
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;// de -128 à 127 (aceita numeros negativos)
            Console.WriteLine("O saldo de gols é: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;//mais usados dos valores inteiros
            Console.WriteLine("menor int" + menorValorInt);

            float precoComputador = 1299.99f;
            Console.WriteLine("O preço do computador é: R$" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000 - 000.00; // Mais usado
            Console.WriteLine("Valor Apple: " + valorDeMercadoDaApple);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);
        }
    }
}
