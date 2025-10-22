using Projetos_Curso_CSharp.Myo.OO.Delegates.Func.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Delegates.Func {
    class Program {
        public void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // ------------------------------------------------------------------- //

            Func<Product, string> func = NameToUpper;
            List<string> resultFunc = list.Select(func).ToList();

            // ------------------------------------------------------------------- //

            Func<Product, string> funcLambda = p => p.Name.ToUpper();
            List<string> resultFuncLambda = list.Select(funcLambda).ToList();

            // ------------------------------------------------------------------- //

            List<string> resultInlineLambda = list.Select(p => p.Name.ToUpper()).ToList();

            // ------------------------------------------------------------------- //

            List<string> resultMethod = list.Select(NameToUpper).ToList();

            // ------------------------------------------------------------------- //

            foreach (string s in resultFunc) {
                Console.WriteLine(s);
            }

        }

        static string NameToUpper(Product p) {
            return p.Name.ToUpper();
        }

    }
}
