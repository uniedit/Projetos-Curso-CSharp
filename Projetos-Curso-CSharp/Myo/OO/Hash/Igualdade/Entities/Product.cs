namespace Projetos_Curso_CSharp.Myo.OO.Hash.Igualdade.Entities {
    class Product {

        public string Name { get; set; }
        public double Price { get; set; }

        // Já no caso de classes normais, não é possivel implementar o "this()"
        // Uma vez que ele implementa o "base()" implicitamente
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override int GetHashCode() {
            // Modo de retornar o Equals para duas variaveis da classe
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj) {
            // Programação defensiva para ver se o obj é a classe Product
            if (!(obj is Product)) {
                return false;
            }

            // Downcasting de obj para Product (vão ser o mesmo tipo então não há perca de informação)
            Product other = obj as Product;
            
            // Modo de retornar o Equals para duas variaveis da classe
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }

    }
}
