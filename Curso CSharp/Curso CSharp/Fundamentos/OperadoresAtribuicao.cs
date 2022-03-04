using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;   //Reatribui novo valor à variavel
            num1 += 10; //Atribuição Aditiva => num1 = num1 + 10
            num1 -= 3;  //Atribuição Negativa => num1 = num1 - 3
            num1 *= 5;  //Atribuição Multiplicativa => num1 = num1 * 5
            num1 /= 2;  //Atribuição Divisiva => num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1;  //Atribuição Literal
            int b = a;  //Atribuição por Referencia

            a++;  // Operador de incremento == a = a + 1
            b--;  // Operador de decremento == b = b + 1

            Console.WriteLine($"{a} {b}");

        }
    }
}
