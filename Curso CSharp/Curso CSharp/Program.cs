using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                //fundamentos
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

                //estruturas de controle
                {"Estrutura IF - Estruturas De Controle", EstruturaIf.Executar},
                {"Estrutura IF / Else - Estruturas De Controle", EstruturaIfElse.Executar},
                {"Estrutura IF / Else / IF - Estruturas De Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas De Controle", EstruturaWhile.Executar},
                {"Estrutura Do / While - Estruturas De Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas De Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas De Controle", EstruturaForEach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Get Set - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
                { "Readonly - Classes e Métodos", Readonly.Executar},
                { "Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                
                // Coleções
                { "Array - Coleções", Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                 { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                { "Herança - OO", Heranca.Executar},
                { "Construtor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polimorfismo.Executar},
                { "Abstract - OO", Abstract.Executar},
                { "Interface - OO", Interface.Executar},
                { "Sealed - OO", Sealed.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}