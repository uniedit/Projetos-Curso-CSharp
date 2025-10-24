using Projetos_Curso_CSharp.Myo.Funcional.Linq.Exercícios.Exer_1.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using System;

namespace Projetos_Curso_CSharp.Myo.Funcional.Linq.Exercícios.Exer_1 {
    class Program {
        public void Main(string[] args) {

            try {

                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();

                Console.Write("Enter salary: ");
                double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Email of people whose salary is more than {salaryLimit}:\n");

                List<Employee> list = new List<Employee>();

                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                }

                var emails = list
                    .Where(p => p.Salary > salaryLimit)
                    .OrderBy(p => p.Email)
                    .Select(p => p.Email);

                foreach (string email in emails) {
                    Console.WriteLine(email);
                }

                var SumSalary = list
                    .Where(p => p.Name.StartsWith("M"))
                    .Select(p => p.Salary)
                    .DefaultIfEmpty(0.0)
                    .Sum();

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {SumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } catch (FormatException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } catch (UnauthorizedAccessException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
