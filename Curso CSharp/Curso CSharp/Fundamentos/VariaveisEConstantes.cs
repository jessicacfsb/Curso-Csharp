using System;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double pi = 3.14;

            raio = 5.5;

            double area = pi * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            //verificar o tamanho maximo de bytes
            long maxUlong = long.MaxValue;
            Console.WriteLine(maxUlong);

            double maxDouble = double.MaxValue;
            Console.WriteLine(maxDouble);

            int maxInt = int.MaxValue;
            Console.WriteLine(maxInt);


        }
    }
}
