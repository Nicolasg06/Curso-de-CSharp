using System;
using System.Globalization;

namespace CursoDeCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            //console.readline é o solicitador de dados no console 
            
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salario? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            //.parse transforma o dado recebido como string e leve para o valor necessario

            Console.WriteLine($"{nome} {idade} R${salario}"); 
        }
    }
}
