using Projetos_Curso_CSharp.Myo.OO.Delegates.Predicate.Entities;
using System;
using System.Collections.Generic;

namespace Projetos_Curso_CSharp.Myo.OO.Delegates.Predicate {
    class Program {
        public void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
                Metodo que recebe um predicate -> "RemoveAll", e esse predicate pode ser tanto
                uma expressão lambda, tanto um metodo que atende a a signatura do predicate, 
                nesse caso foi uma função que retorna "bool".

                list.RemoveAll(p => p.Price >= 100.0); <- Nesse caso foi a função anonima Lambda
                list.RemoveAll(ProductTest); <- E nesse função que retorna bool
            */

            list.RemoveAll(ProductTest);

            foreach (Product p in list) {
                Console.WriteLine(p);
            }

        }

        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }

    }
}
