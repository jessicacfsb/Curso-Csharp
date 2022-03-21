using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        //variaveis podem ser modificadas quanto ao tipo

        public static void Executar() {
            dynamic meuObjeto = "teste"; //aqui declarada como string
            meuObjeto = 3;  //aqui redeclarada como int

            meuObjeto++;  //aqui ela pagou o ultimo tipo declarado e fez incremento somatorio
            Console.WriteLine(meuObjeto);

            //deve ter muito cuidado para nao causar bugs nesse tipo de modificações

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}