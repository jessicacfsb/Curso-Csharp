using AutoProperties;
using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("tv", 5000.0, 10);

            p.Nome = "TV 4k"; // seta um novo valor 
            //p.Nome = "T";
            //p.Preco = 2000.00  nao consigo modificar pq nao tem o set!

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
