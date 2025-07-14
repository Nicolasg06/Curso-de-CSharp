using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.ClassesEMetodos
{
     class Membros
    {
        public static void Executar()
        {
            Pessoa ciclano = new Pessoa();
            ciclano.Nome = "Renato";
            ciclano.Idade = 21;

           // Console.WriteLine($"{ciclano.Nome} tem {ciclano.Idade} aos.");

            ciclano.ApresentarNoConsole();
            ciclano.Zerar();
            ciclano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Nicolas";
            fulano.Idade = 26;

            var apresentacaoFulano = fulano.Apresentar();
        }
    }
}
