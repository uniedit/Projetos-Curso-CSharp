using Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_2.Entities;
using System;
using System.Collections.Generic;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_2 {
    class Program {
        public void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++) {

                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                string lowerResp = resp.ToString().ToLower();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), C.I);

                if (lowerResp == "i") {
                    Console.Write("Customs fee: ");
                    double custFee = double.Parse(Console.ReadLine(), C.I);
                    list.Add(new ImportedProduct(name, price, custFee));
                } else if (lowerResp == "c") {
                    list.Add(new Product(name, price));
                } else if (lowerResp == "u") {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuTime = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manuTime));
                }

            }

            Console.WriteLine("");

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list) {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
