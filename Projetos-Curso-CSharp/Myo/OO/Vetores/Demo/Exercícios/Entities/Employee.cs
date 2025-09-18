using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo.Entities {
    internal class Employee {

        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public Employee() {
        }

        public Employee (int id, string name, double salary) {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void increaseSalary(double percentage) {
            salary = ((percentage / 100) * salary) + salary;
        }

        public override string ToString() {
            return $"{id}, {name}, R$ {salary.ToString("F2", C.I)}";
        }

    }
}
