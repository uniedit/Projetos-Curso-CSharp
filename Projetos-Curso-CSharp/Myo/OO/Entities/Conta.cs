using System;
using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.OO.Entities {
    internal class Conta {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }

        public Conta() {
        }

        public Conta(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        // Uso do this para deixar mais "dinamico" o construtor e reutilizar o codigo :3
        public Conta(int numeroConta, string titularConta, double saldoConta) : this (numeroConta, titularConta) {
            SaldoConta = saldoConta;
        }

        public void Deposito(double valor) {
            SaldoConta += valor;
        }

        public void Saque(double valor) {
            SaldoConta -= valor + 5.0;
        }

        public override string ToString() {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo: $ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
