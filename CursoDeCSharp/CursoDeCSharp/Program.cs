using System;
using System.Collections.Generic;
using CursoDeCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariavesEConstantes.Executar },
                {"Inferencias - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados- Fundamentos", LendoDados.Executar },
                {"Formatando Números- Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores aritimeticos - Fundamentos", OperadoresAritimeticos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}