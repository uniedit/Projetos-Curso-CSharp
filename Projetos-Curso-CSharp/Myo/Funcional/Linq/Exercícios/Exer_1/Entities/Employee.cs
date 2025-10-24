namespace Projetos_Curso_CSharp.Myo.Funcional.Linq.Exercícios.Exer_1.Entities {
    class Employee {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary) {
            Name = name;
            Email = email;
            Salary = salary;
        }

    }
}
