using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class NegativoException : Exception {
        public NegativoException() { }  //Construtor padrão
        public NegativoException(string message) : base(message){ } //Construtor base
        public NegativoException(string message, Exception inner) //Recebe uma exceção que está causando a outra exceção
            : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }

    }

    class ExcecoesPersonalizadas {
        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0) {
                throw new NegativoException("Numero negativo...:(");
            }

            if (valor % 2 == 1) {
                throw new ImparException("Valor impar...:(");
            }

            return valor;
        }
        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
     }
}
