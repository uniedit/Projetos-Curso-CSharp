using System;
using System.Collections.Generic;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.Dictionary_e_SortedDictionary {
    class Program {
        public void Main(string[] args) {

            // Sintaxe para criar um Dictionary com Key: String e Value: String
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // Inserção de elementos no Dictionary
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";

            // Impressão de uma Key
            Console.WriteLine(cookies["email"]);

            // Remõção de uma Key
            cookies.Remove("email");

            Console.WriteLine("Phone number: " + cookies["phone"]);

            if (cookies.ContainsKey("email")) {
                Console.WriteLine("Email: " + cookies["email"]);
            } else {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES:");

            // Modo de percorrer um dictionary
            // Também é possivel usar o var item
            foreach (KeyValuePair<string, string> item in cookies) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
