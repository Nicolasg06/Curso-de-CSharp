﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Bom!");
                    break;
                case 5:
                    Console.WriteLine("Otimo!");
                    break;
                default:
                    Console.WriteLine("nota invalida");
                    break;
            }
            Console.WriteLine("Fim!");
        }
    }
}
