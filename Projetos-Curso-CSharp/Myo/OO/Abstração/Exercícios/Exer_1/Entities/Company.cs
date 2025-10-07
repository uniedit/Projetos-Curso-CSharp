namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Exercícios.Exer_1.Entities {
    class Company : TaxPayer {

        public Company() {
        }

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) 
            : base(name, anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if (NumberOfEmployees < 10) {
                return (AnualIncome * 0.16);
            } else {
                return (AnualIncome * 0.14);
            }
        }

    }
}
