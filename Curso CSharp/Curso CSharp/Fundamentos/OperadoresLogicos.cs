using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            //E
            bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a tv 50? {0}", comprouTV50);

            //OU
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            //OU exlusivo
            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a tv 32? {0}", comprouTV32);

            //negação logica
            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);


        }
    }
}
