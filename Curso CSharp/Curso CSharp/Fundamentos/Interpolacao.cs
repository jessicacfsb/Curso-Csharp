using System;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "notebook gamer";
            string marca = "Dell";
            double preco = 5800.00;

            //concatenação
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            //interpolação
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            //interpolação c/ tipo junto
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");

            //interpolação com dados
            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}
