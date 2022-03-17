﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    //Para usar o polimorfismo:
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        
        public Comida() { }
    }


    public class Feijao : Comida {
        //public double Peso;
        public Feijao(double Peso) : base(Peso) { }
    }

    public class Arroz : Comida {
        //public double Peso;
    }

    public class Carne : Comida {
        //public double Peso;
    }

    public class Pessoa {
        public double Peso;

        /*public void Comer(Feijao feijao) {
            Peso += feijao.Peso;
        }

        public void Comer(Arroz arroz) {
            Peso += arroz.Peso;
        }

        public void Comer(Carne carne) {
            Peso += carne.Peso;
        }*/

        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao(0.3);
            //ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa Cliente = new Pessoa();
            Cliente.Peso = 80.2;
            Cliente.Comer(ingrediente1);
            Cliente.Comer(ingrediente2);
            Cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do Cliente é de {Cliente.Peso} Kg!!!");
        }
    }
}
