using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa siclano = new Pessoa();
            siclano.Nome = "Jessica";
            siclano.Idade = 25;

            //Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos.");

            siclano.ApresentarNoConsole();

        }
    }
}
