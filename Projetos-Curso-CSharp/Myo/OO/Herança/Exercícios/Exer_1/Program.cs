using Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_1.Entities;
using System;
using System.Collections.Generic;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_1 {
    class Program {
        public void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++) {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valurPerHour = double.Parse(Console.ReadLine(), C.I);

                string lowerResp = resp.ToString().ToLower();

                if (lowerResp == "y") {

                    Console.Write("Additional charge: ");
                    double aditionalCharge = double.Parse(Console.ReadLine(), C.I);
                    list.Add(new OutsourcedEmployee(name, hours, valurPerHour, aditionalCharge));
                } else if (lowerResp == "n") {
                    list.Add(new Employee(name, hours, valurPerHour));
                } else {
                    Console.WriteLine("Something went wrong. Exiting.");
                    break;
                }

            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in list) {
                Console.WriteLine($"{emp.name} - $ {emp.Payment().ToString("F2", C.I)}");
            }

        }
    }
}
