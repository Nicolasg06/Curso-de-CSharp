﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "ANA", "bia", "Carlos" };
            
            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
