using System;

namespace Projetos_Curso_CSharp.Myo.OO.Herança {
    internal class Program {
        public void Method() {

            Account acc = new Account(1001, "Alex Greeno", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Paraiba", 0.0, 400.00);
            Account acc3 = new SavingsAccount(1004, "Tecleino", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.00);
            //acc2.Loan(100.00);

            // Erro na Hora da execução do Programa
            //BusinessAccount acc5 = (BusinessAccount) acc3;

            // Testar caso o acc3 for uma INSTANCIA de BusinessAccount
            // is == é uma instacia
            if (acc3 is BusinessAccount) { // False
              //BusinessAccount acc5 = (BusinessAccount) acc3;

                // Sintaxe alternativa para o casting padrão
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Parabens!");
            }

            if (acc3 is SavingsAccount) { // True
                //SavingsAccount acc5 = (SavingsAccount) acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!");
            }

        }
    }
}
