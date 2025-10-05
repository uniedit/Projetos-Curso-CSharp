using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_2.Entities {
    class ImportedProduct : Product {

        public ImportedProduct() {
        }

        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee)
            : base (name, price) {
            CustomFee = customFee;
        }

        public double TotalPrice() {
            return Price + CustomFee;
        }

        public override string PriceTag() {
            return $"{Name} $ {TotalPrice().ToString("F2", C.I)} " +
                $"(Custom fee: $ {CustomFee.ToString("F2", C.I)})";
        }

    }
}
