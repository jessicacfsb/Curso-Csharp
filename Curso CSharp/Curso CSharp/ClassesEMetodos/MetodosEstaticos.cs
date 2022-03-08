using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {

        // Método de Classe ou Método estático (colocar static e nao instanciar).
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de instância (no codigo vai ter que instanciar ex. Somar s = new Somar();
        public int Somar(int a, int b) {
            return a + b;
        }
    }

    class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));

            /*BASTA chamar pelo NomeDaclasse.NomeDoMetodo();
             *Ex. Funcionario.Salario();
             *Se no método possuir parametros TEM que colocar os parametros entre ()...
             *tbm TEM que ser os mesmos parametros do metodo*/
        }
    }
}
