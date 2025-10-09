using C = Projetos_Curso_CSharp.Global.Global;
using System;
using Projetos_Curso_CSharp.Myo.Exceções.Exercícios.Exer_1.Entities.Exceptions;

namespace Projetos_Curso_CSharp.Myo.Exceções.Exercícios.Exer_1.Entities {
    class Program {
        public void Main(string[] args) {

            try {

                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), C.I);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), C.I);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine("");

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), C.I);
                account.Withdraw(amount);

                Console.WriteLine($"New balance: {account.Balance.ToString("F2", C.I)}");

            } catch (DomainException err) {
                Console.WriteLine($"Withdraw error: {err.Message}");
            } catch (FormatException err) {
                Console.WriteLine($"Error in format: {err.Message}");
            } catch (Exception err) {
                Console.WriteLine($"Unexpected Error: {err.Message}");
            }

        }
    }
}
