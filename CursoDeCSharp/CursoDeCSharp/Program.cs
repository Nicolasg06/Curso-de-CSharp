﻿using System;
using System.Collections.Generic;
using CursoDeCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariavesEConstantes.Executar }
            });

            central.SelecionarEExecutar();
        }
    }
}