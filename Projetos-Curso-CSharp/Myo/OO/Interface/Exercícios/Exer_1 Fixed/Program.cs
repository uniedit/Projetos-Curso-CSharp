using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Entities;
using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Services;
using C = Projetos_Curso_CSharp.Global.Global;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed {
    class Program {
        public void Main(string[] args) {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", C.I);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), C.I);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }

        }
    }
}
