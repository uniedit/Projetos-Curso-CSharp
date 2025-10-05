using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_2.Entities {
    class Product {

        public Product() {
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {
            return $"{Name} $ {Price.ToString("F2", C.I)}";
        }

    }
}
