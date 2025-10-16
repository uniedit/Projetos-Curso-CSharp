using Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Com_Restrição.Entities;
using Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Com_Restrição.Services;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Com_Restrição {
    class Program {
        public void Main(string[] args) {

            // Declarando uma lista do tipo Product
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            // Devido as implementações feitas em CalculationService e no Product, agora
            // ele pode ser comparado a um object, no caso ver qual é maior :)
            Product p = calculationService.Max(list); 

            Console.WriteLine("Most expensive:");
            Console.WriteLine(p);

        }
    }
}
