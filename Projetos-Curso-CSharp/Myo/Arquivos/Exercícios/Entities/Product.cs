using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.Arquivos.Exercícios.Entities {
     class Product {
        public Product() {
        }

        public string name { get; set; }
        public double price { get; set; }
        public int qtd { get; set; }

        public Product(string name, double price, int qtd) {
            this.name = name;
            this.price = price;
            this.qtd = qtd;
        }

        public double Total() {
            return price * qtd;
        }

        public override string ToString() {
            return $"{name},{Total().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
