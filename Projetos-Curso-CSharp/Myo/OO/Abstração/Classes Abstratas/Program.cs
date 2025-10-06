using System;
using System.Collections.Generic;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Abstração {
    internal class Program {
        public void Method() {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Jão Pereira", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Ronado", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Castro", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "José", 500.0, 500.0));

            double sum = 0;

            foreach (Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total Balance: {sum.ToString("F2", C.I)}");

            foreach (Account acc in list) {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list) {
                Console.WriteLine($"Account Number: {acc.Number}" +
                    $": " +
                    $"{acc.Balance.ToString("F2", C.I)}");
            }

            sum = 0;

            foreach (Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total Balance: {sum.ToString("F2", C.I)}");

        }
    }
}
