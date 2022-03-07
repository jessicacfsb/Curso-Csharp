using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {

            int nota;

            Console.Write("Avalie meu atendimento com uma nota de 1 a 5: ");
            nota = int.Parse(Console.ReadLine());

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Regular");
                    break;
                case 3:
                    Console.WriteLine("Bom");
                    break;
                case 4:
                    Console.WriteLine("Ótimo");
                    Console.WriteLine("Parabéns!");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");

        }
    }
}
