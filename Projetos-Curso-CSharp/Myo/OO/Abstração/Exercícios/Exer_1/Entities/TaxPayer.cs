namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Exercícios.Exer_1.Entities {
    abstract class TaxPayer {

        public TaxPayer() {
        }

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
