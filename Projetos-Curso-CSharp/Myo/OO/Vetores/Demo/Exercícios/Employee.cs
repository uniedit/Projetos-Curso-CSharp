using Projetos_Curso_CSharp.Myo.OO.Vetores.Demo.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class5 {
        public void Method() {

            Console.Write("How many employees will be registered? ");
            int reg = int.Parse(Console.ReadLine());
            List<Employee> listGlobal = new List<Employee>();

            Employee emp = new Employee();

            for (int i = 0; i < reg; i++) {
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write("Id: ");
                emp.id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                emp.name = Console.ReadLine();
                Console.Write("Salary: ");
                emp.salary = double.Parse(Console.ReadLine(), C.I);
                Console.WriteLine("");

                listGlobal.Add(new Employee(emp.id, emp.name, emp.salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int id = int.Parse(Console.ReadLine());
            Employee empFind = listGlobal.Find(x => x.id == id);

            if (empFind != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), C.I);
                empFind.increaseSalary(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in listGlobal) {
                Console.WriteLine(obj);
            }
        }
    }
}

