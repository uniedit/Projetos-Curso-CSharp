using Projetos_Curso_CSharp.Myo.OO.Lambda.Demo.Entities;
using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Lambda.Demo {
    class Program {
        public void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Expressão Lambda usando a interface Comparison para comparar duas vars
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(comp);

            foreach (Product p in list) {
                Console.WriteLine(p);
            }

        }
    }
}
