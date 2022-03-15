using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        //ATRIBUTOS

        //Todos podem acessar 
        public string InfoPublica = "Tenho um instagam!";

        //herança
        protected string CorDoOlho = "Verde";

        //mesmo assembly
        internal ulong NumeroDoCelular = 5553423423423420;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        //private PADRAO
        bool UsaMuitoPhotoshop = true;

        //ver quais atributos podem ser acessados estando na mesma classe
        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade... ");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
