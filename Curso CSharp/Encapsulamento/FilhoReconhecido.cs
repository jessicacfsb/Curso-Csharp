using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    class FilhoReconhecido : SubCelebridade{ // o -> : significa herdado

        //ver quais atributos eu recebe de herança como filho 
        public new void MeusAcessos() {
            Console.WriteLine("Filho Reconhecido... ");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);  privado, somente a celebridade tem acesso
        }
    }
}
