using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"CursoCSharp - fundamentos" , PrimeiroPrograma.Executar},
                {"Variaveise e Constantes - fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - fundamentos", Inferencia.Executar},
                {"Interpolacao - fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - fundamentos", LendoDados.Executar},
                {"Formatando numero - fundamentos", FormatandoNumero.Executar},
                {"Conversoes - fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuição - fundamentos", OperadoresAtribuicao.Executar},
                {"Operador Ternario - fundamentos", OperadorTernario.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}