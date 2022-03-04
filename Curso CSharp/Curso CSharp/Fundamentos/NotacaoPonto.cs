using System;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!").ToUpper();
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            //cuidado com a notacao ponto em dados vazios
            //Usar a ? para tornar a navegação de valores vazios mais segura(sem erros);
        }
    }
}
