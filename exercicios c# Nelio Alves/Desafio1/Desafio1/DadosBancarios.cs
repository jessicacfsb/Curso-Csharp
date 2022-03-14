using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desafio1 {
    class DadosBancarios {

        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public DadosBancarios(int numeroConta, string nomeTitular) {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public DadosBancarios(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular) {
            Saldo = saldo;
        }

        public string Nome {
            get { return NomeTitular; }
            set {
                if (value != null && value.Length > 1) {
                    NomeTitular = value;
                }
            }
        }

        public void Deposito (double deposito){
            if (deposito > 0) {
                    Saldo += deposito;
             }
        }

        public void Saque (double quantia) {
            Saldo -= quantia + 5.00;
        }

        /*public double Saque {
            get { return Saldo - ; }
            set {
                Valor = Saldo + value - 5.00;
            }
        }*/

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
