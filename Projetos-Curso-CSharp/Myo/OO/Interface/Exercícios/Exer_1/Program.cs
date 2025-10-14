using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Entities;
using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Services;
using C = Projetos_Curso_CSharp.Global.Global;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1 {
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
            Installment installment = new Installment(date, value);

            RentalService rentalService = new RentalService(new Paypal());

            Console.WriteLine("Installments:");
            Console.WriteLine($"{rentalService.NewInstallment(value, installments, date)}");

        }
    }
}
