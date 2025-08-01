﻿using System;
using System.Collections.Generic;
using CursoDeCSharp.ClassesEMetodos;
using CursoDeCSharp.EstruturasDeControle;
using CursoDeCSharp.Fundamentos;
using CursoDeCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               //Fundamentos 
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
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar },
              
                //Estruturas de Controle 
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura IfElse - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IfElseIf - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}