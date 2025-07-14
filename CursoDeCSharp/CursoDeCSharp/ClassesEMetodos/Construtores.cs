using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.ClassesEMetodos
{class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(  string fabricante, string modelo, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;  
        }
        public Carro()
        {
           
        }
    }
     class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "vw";
            carro1.Modelo = "GOL";
            carro1.Ano = 2026;
            Console.WriteLine($"A fabrica da {carro1.Fabricante} produziu o modelo de carro {carro1.Modelo}, no ano de {carro1.Ano}.");

            var carro2 = new Carro("BWM", "X6", 2026);
            Console.WriteLine($"A fabricante {carro2.Fabricante} produziu o modelo de carro {carro2.Modelo}, no ano de {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 1990
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
