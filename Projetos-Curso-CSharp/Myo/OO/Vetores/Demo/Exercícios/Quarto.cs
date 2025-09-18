using Projetos_Curso_CSharp.Myo.OO.Vetores.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class1 {
        public void Method() {

            Room[] vect = new Room[10];

            Console.Write("Quantos quartos vão ser reservados? ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n");

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("\n");

                // Sem construtor
                //vect[quarto] = new Room { nome = nome, email = email, quarto = quarto };

                // Com construtor
                vect[quarto] = new Room(nome, email);

            }

            Console.WriteLine("Quartos Oculpados: ");
            for (int i = 0; i < 10; i++) {

                if (vect[i] != null) {
                    Console.WriteLine($"{i}: {vect[i].nome}, {vect[i].email}");
                }
            }

        }
    }
}
