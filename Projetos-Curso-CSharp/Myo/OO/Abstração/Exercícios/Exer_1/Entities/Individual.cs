namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Exercícios.Exer_1.Entities {
    class Individual : TaxPayer {

        public Individual() {
        }

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            if (AnualIncome < 20000) {
                return (AnualIncome * 0.15) 
                    - (HealthExpenditures * 0.5);
            } else {
                return (AnualIncome * 0.25)
                    - (HealthExpenditures * 0.5);
            } 
        }

    }
}
