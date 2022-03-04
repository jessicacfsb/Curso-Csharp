using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("PT-BR");
            Console.WriteLine(valor.ToString("C1", cultura));

            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura2));

            //os zeros serão ignorados
            int inteiro = 000256;
            Console.WriteLine(inteiro);

            //os zeros serao exibidos
            int inteiro2 = 256;
            Console.WriteLine(inteiro2.ToString("D6"));
        }
    }
}
