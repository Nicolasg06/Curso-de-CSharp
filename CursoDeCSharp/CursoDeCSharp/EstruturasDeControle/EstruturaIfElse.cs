﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.EstruturasDeControle
{
     class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;
            if (nota>= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");


            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
