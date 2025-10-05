namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_1.Entities {
    class OutsourcedEmployee : Employee {

        public double AditionalCharge { get; set; }

        public OutsourcedEmployee() {
        }

        public OutsourcedEmployee(string name, int hours, double valurPerHour, double aditionalCharge) : base(name, hours, valurPerHour) {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment() {
            AditionalCharge *= 1.1;
            return base.Payment() + AditionalCharge;
        }

    }
}
