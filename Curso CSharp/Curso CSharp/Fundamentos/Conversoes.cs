using System;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            //int p/ double de forma implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //casting

            double nota = 9.7;
            //EX = int notaTruncada = nota;
            //double p/ int nao converte de forma implicita pq haverá perda de informações
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            //string p/ numero
            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine(); //recebe como string
            int idadeInteiro = int.Parse(idadeString); //converte para numero
            Console.WriteLine("idade inserida {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); //converte com o convert
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            //tentar, se nao conseguir ele exibe o zero
            //NÃO gera um problema (ERRO)
            Console.WriteLine("Digite um numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado1: {0}", numero1);

            Console.WriteLine("Digite o segundo numero: ");
            int numero2;
            int.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine("Resultado2: {0}", numero2);
        }
    }
}
