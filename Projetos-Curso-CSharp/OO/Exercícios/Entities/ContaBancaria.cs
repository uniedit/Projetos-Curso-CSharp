using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp.OO.Entities {
    class ContaBancaria {

        public string NumeroConta { get; private set; }
        public string TitularConta { get; private set; }
        public double ValorDeposito { get; private set; }
        public double Tax = 5.0;


        public ContaBancaria() { 
        }

        public ContaBancaria(string numero, string titular) {
            NumeroConta = numero;
            TitularConta = titular;
        }

        public void ValorInicial(double value) {
            ValorDeposito = value;
        }

        public void Deposito(double value) {
            ValorDeposito += value;
        }

        public void Saque(double value) {
            ValorDeposito = ValorDeposito - value - Tax;
        }


        public override string ToString() {
            return $"Conta {NumeroConta}, Titular: {TitularConta}, Saldo: $ {ValorDeposito.ToString("F2", C.I)}";
        }


    }
    }
