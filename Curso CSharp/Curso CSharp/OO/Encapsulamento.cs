using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Não Reconhecido... ");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroDoCelular);   somente no mesmo projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);    somente por herança dentro do próprio projeto
            //Console.WriteLine(UsaMuitoPhotoshop);    Private
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante...");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);          apenas herança
            //Console.WriteLine(amigo.NumeroDoCelular);    apenas internal
            //Console.WriteLine(amigo.JeitoDeFalar);       apenas internal ou herança
            //Console.WriteLine(amigo.SegredoFamilia);     apenas herança ou classe
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);  apenas a subcelebridade pois é private
        }
    }

    class Encapsulamento {
        public static void Executar() {

        }
    }
}

