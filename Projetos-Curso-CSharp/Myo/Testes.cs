using Projetos_Curso_CSharp.Myo.Funcional.Linq.Demo_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp {
    class Testes {

        static void Print<Generic>(string message, IEnumerable<Generic> collection) {
            Console.WriteLine(message);
            foreach (Generic obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {

            //double insano = 1.69;
            //Console.WriteLine($"Hi\nTyler!! {insano.ToString("F", C.I)}");

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            Print("Tier 1 and price < 900:", r1);

            var r2 = products
                .Where(p => p.Category.Name.Equals("Tools"))
                .Select(p => p.Name);

            Print("Name of products from tools: ", r2);

            var r3 = products
                .Where(p => p.Name.StartsWith("C")) // p => p.Name[0] == 'C'
                .Select(p => new {
                    // Alias == Apelido para o p.Category.Name por causa de Ambiguidade
                    // E objeto anonimo
                    p.Name, p.Price, CategoryName = p.Category.Name
                }); // p => p.Name && p.Price && p.Category

            Print("Products that starts with 'C' and Anonymous object ", r3);

            var r4 = products
                .Where(p => p.Category.Tier == 1)
                .OrderByDescending(p => p.Price)
                .ThenBy(p => p.Name);

            Print("Tier 1 orded by price then by name", r4);

            var r5 = r4.Skip(2).Take(4);

            Print("Skip 2 then take 4 from r4", r5);

            var r6 = products.First();
            Console.WriteLine($"First in Products: {r6}");

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine($"First or Default in Products: {r7}");

            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or Default ID: {r8}");

            var r9 = products.Where(p => p.Id == 11).Select(p => p.Id);
            Console.WriteLine($"Without Single or Default (return collection) ID: {r9}");

            Console.WriteLine();

        }
    }
}
