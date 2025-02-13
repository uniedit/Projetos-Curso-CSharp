using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe88 {
        internal class Class1 {
            public void Method() {

                ContaBancaria conta;  // Apenas declarando construtor sem argumentos

                Console.Write("Entre o número da conta: ");
                string numero = Console.ReadLine();
                Console.Write("Entre o titular da conta: ");
                string titular = Console.ReadLine();

                Console.Write("Haverá depósito inicial (s/n)? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's') {
                    Console.Write("Entre o valor de depósito incial: ");
                    double valor = double.Parse(Console.ReadLine(), C.I);
                    Console.WriteLine();

                    conta = new ContaBancaria(numero, titular, valor);
                } else {
                    conta = new ContaBancaria(numero, titular);
                    Console.WriteLine();
                }

                Console.WriteLine($"Dados da conta: \n{conta} \n");

                Console.Write($"Entre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), C.I);
                conta.Deposito(deposito);

                Console.WriteLine($"Dados da conta atualizados: \n{conta} \n");

                Console.Write($"Entre um valor para saque: ");
                double saqque = double.Parse(Console.ReadLine(), C.I);
                conta.Saque(saqque);

                Console.WriteLine($"Dados da conta atualizados: \n{conta} \n");

            }
        }
    }
}