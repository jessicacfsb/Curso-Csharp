using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public abstract class Celular {
        public abstract string Assistente();    //metodo abstrato - esses metodos qd herdados por uma
                                                // classe concreta essa classe tera que implementar (Ele esta sendo implementado na linha 15

        public string Tocar() {                //metodos concretos
            return "Trim trim trim";
        }
    }

    public class Samsung : Celular {          //implementando o metodo abstrato
        public override string Assistente() {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular {           //implementando o metodo com um novo Celular!
        public override string Assistente() {
            return "Olá! Meu nome é Siri!";
        }
    }

    class Abstract {
        public static void Executar() {
            //Não pode instanciar classes abstratas
            //Ela só pode ser Herdada
            //Celular c = new Celular();

            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
