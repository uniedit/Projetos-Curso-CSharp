namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_1.Entities {
    class Employee {

        public string name { get; set; }
        public int Hours { get; set; }
        public double ValurPerHour { get; set; }

        public Employee() {
        }

        public Employee(string name, int hours, double valurPerHour) {
            this.name = name;
            Hours = hours;
            ValurPerHour = valurPerHour;
        }

        public virtual double Payment() {
            return ValurPerHour * Hours;
        }

    }
}
