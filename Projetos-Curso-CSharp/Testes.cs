using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp {
    internal class Testes {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            ContaBancaria x = new ContaBancaria(numero, titular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            char s = char.Parse(Console.ReadLine());

            if (s == 's') {
                Console.Write("Entre o valor de depósito incial: ");
                double valor = double.Parse(Console.ReadLine(), C.I);
                Console.WriteLine();

                x.ValorInicial(valor);

            } else {
                Console.WriteLine();
            }

            Console.WriteLine($"Dados da conta: \n{x} \n");

            Console.Write($"Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), C.I);
            x.Deposito(deposito);

            Console.WriteLine($"Dados da conta atualizados: \n{x} \n");

            Console.Write($"Entre um valor para saque: ");
            double saqque = double.Parse(Console.ReadLine(), C.I);
            x.Saque(saqque);

            Console.WriteLine($"Dados da conta atualizados: \n{x} \n");



        }
    }
}