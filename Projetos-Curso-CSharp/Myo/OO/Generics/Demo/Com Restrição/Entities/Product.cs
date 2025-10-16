using System.Globalization;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Com_Restrição.Entities {

    // Usando o IComparable para que uma classe que utilize o "Product" como tipo
    // possa assim usar jeitos de comparar objetos.
    class Product : IComparable {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // Metodo padrão da Interface IComparable
        public int CompareTo(object obj) {

            // Programação defensiva
            if (!(obj is Product)) {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }

            // Declarando o "Product" como other, e fazendo com que o objeto inserido como argumento
            // possa ser igual ao "Product"
            Product other = obj as Product;

            // Uma vez que o obj é igual ao "product" ele pode implementar o .CompareTo
            return Price.CompareTo(other.Price);
        }

        public override string ToString() {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
