using Encapsulamento;
using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("tv", 5000.0, 10);

            p.SetNome("TV 4k");
            //p.SetNome("T");  ñ exibe pq ñ esta de acordo com a regra

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
