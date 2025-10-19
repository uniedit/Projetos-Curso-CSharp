using Projetos_Curso_CSharp.Myo.OO.Hash.Igualdade.Entities;
using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.Igualdade {
    class Program {
        public void Main(string[] args) {

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));
               
            Product prod = new Product("Notebook", 1200.0);
            
            // Caso o Product não tenha implementado o override do GetHashCode e do Equals
            // Ele vai retornar o endereço de memoria da classe, logo sempre false (caso instanciações diferentes)
            Console.WriteLine(a.Contains(prod));
            
            Point point = new Point(5, 10);
            // Sempre retorna true caso o conteudo for o mesmo
            Console.WriteLine(b.Contains(point));

        }
    }
}
