using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    class AmigoProximo {

        //nao é filho entao não recebe herança / cria-se uma instancia para acessar
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Próximo... ");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);   nao tem acesso, só se for por herança
            Console.WriteLine(amigo.NumeroDoCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia);   nao tem acesso, só se for por herança
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);   nao tem acesso, privativo a celebridade
        }
    }
}
