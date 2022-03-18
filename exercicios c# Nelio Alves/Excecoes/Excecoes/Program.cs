using System;

namespace Excecoes {
    class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e) {       //o "e" é um apelido para o erro para poder chamar e exibir a mensagem de erro
                Console.WriteLine("Error! " + e.Message);

                //catch (DivideByZeroException) {
                //Console.WriteLine("Division by zero is not allowed"); erro com meu texto
            }
            catch(FormatException e) {
                Console.WriteLine("Format Error! " + e.Message);
            }

            //o finally é opcional, geralmente usado para fechar a conexão com banco por ex.
        }
    }
}
