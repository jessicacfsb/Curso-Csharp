using System;
using System.Globalization;

namespace Desafio1 {
    class Program {
        static void Main(string[] args) {

            DadosBancarios conta;
            

            Console.Write("Entre com o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new DadosBancarios(numeroConta,
                                           nomeTitular,
                                           depositoInicial);
            }
            else {
                conta = new DadosBancarios(numeroConta, 
                                           nomeTitular);
            }

            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine(conta);
        }
    }
}
