using Projetos_Curso_CSharp.Myo.Enumeração.Entities.Enums;
using System.Collections.Generic;

namespace Projetos_Curso_CSharp.Myo.Enumeração.Entities {
    class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação entre duas classes diferentes
                                                   // a fim de fazer uma *Composição de Objetos*.

        /* 
            * Para fazer uma Composição de Objetos entre varios "Contratos" 
            * no caso varias classes "HourContract", a lista se faz necessária.
        */

        public List<HourContract> Contracts = new List<HourContract>(); // Nome Contracts é do diagrama UML.
                                                                        // A Instanciação da lista de faz importante
                                                                        // para que a mesma não seja nula.
        public Worker() {
        }

        /*
            * Por padrão o argumento HourContract não vai ser passado para o construtor,
            * devido a composição de objetos -> "para muitos", isso não faria sentido.
        */

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;

            // Foreach para percorrer toda lista e verificar caso seja o ano fornecido e etc.
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

        public override string ToString() {
            return $"Name: {Name}\nDepartment: {Department.Name}\n";
        }

    }
}
