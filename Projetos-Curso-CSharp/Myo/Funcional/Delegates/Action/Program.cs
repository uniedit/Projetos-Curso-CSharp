using Projetos_Curso_CSharp.Myo.OO.Delegates.Action.Entities;
using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Delegates.Action {
    class Program {
        public void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
                Usando só a função para dar update
                list.ForEach(UpdatePrice);    
                
                Função Lambda usando ForEach da lista para aumento de preço inline
                list.ForEach(p => { p.Price += p.Price * 0.1; });
                
                Usando Labda tabém, porém usando o delegate "Action" para declarar a função anonima
                Action<Product> act = p => { p.Price += p.Price * 0.1; };
                list.ForEach(act);

                Usando delegate para dar update na lista
                Action<Product> act = UpdatePrice;
                list.ForEach(act);
            */

            // Delegate Action não retorna nada, pois é void
            Action<Product> act = UpdatePrice;

            // list.ForEach recebe um delegate
            list.ForEach(act);

            foreach (Product p in list) {
                Console.WriteLine(p);
            }

        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }

    }
}
