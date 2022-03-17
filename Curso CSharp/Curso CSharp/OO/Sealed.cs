using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

        //class SouFilho : SemFilho { }   Não é possivel herdar de uma SEALED

        class Avo {
            public virtual bool HonrarNomeFamilia() {
                return true;
            }
        }

        class Pai : Avo {
            public sealed override bool HonrarNomeFamilia() {
                return true;
            }
        }

        class FilhoRebelde : Pai {
            //public override bool HonrarNomeFamilia() {
            //    return false;
            //}
            //nao é possivel sobrescrever um metodo selado
        }

    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
