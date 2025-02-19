using Projetos_Curso_CSharp.Myo;
using Projetos_Curso_CSharp.Myo.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class ClassFiv {
        public void Method() {

            double depositoInicial;
            // Conta conta = new Conta(); <<- Caso não houvesse a instanciação da conta, não seria possivel a utilização de seus metodos :3
            // Conta conta; <<- Pois há instanciação dos metodos mais tarde no programa :3
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's') {
                Console.Write("Entre o valor do depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), C.I);
                conta = new Conta(numeroConta, titularConta, depositoInicial);
            } else {
                conta = new Conta(numeroConta, titularConta);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta + "\n");

            Console.Write("Você quer depositar ou sacar (d/s)? ");
            resp = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            int i = 1;
            do {
                if (resp == 'd' || resp == 'D') {
                    Console.Write("Entre um valor para depósito: ");
                    conta.Deposito(double.Parse(Console.ReadLine(), C.I));
                    Console.WriteLine("");
                } else if (resp == 's' || resp == 'S') {
                    Console.Write("Entre um valor para saque: ");
                    conta.Saque(double.Parse(Console.ReadLine(), C.I));
                    Console.WriteLine("");
                }

                Console.Write("Você quer continuar (s/n)? ");
                char respSN = char.Parse(Console.ReadLine());

                if (respSN == 's' || respSN == 'S') {
                    Console.Write("Você quer depositar ou sacar (d/s)? ");
                    resp = char.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }

                if (respSN == 's' || respSN == 'S') {
                    i++;
                } else if (respSN == 'n' || respSN == 'N') {
                    i = 0;
                }
            } while (i >= 1);

            Console.WriteLine("");
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta + "\n");

        }
    }
}

