using System;
using System.Collections.Generic;
using C = Projetos_Curso_CSharp.Global.Global;
using Projetos_Curso_CSharp.Myo.OO.Abstração.Exercícios.Exer_1.Entities;

namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Exercícios.Exer_1 {
    class Program {
        public void Main(string[] args) {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++) {

                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                string lowerResp = resp.ToString().ToLower();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), C.I);

                if (lowerResp == "i") {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), C.I);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                } else if (lowerResp == "c") {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }

            double totalTax = 0;

            Console.WriteLine("");

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list) {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", C.I)}");
                totalTax += taxPayer.Tax();
            }

            Console.WriteLine("");

            Console.WriteLine($"TOTAL TAXES: $ {totalTax.ToString("F2", C.I)}");

        }
    }
}
