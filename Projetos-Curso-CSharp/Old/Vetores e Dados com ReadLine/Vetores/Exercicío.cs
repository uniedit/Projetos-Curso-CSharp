using Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine.Vetores.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe93 {
        internal class Class1 {
            public void Method3() {

                Console.Write("Quantos quartos serão alugados? ");
                int n = int.Parse(Console.ReadLine());
                int OO = 10;
                Aluguel[] vect = new Aluguel[OO];

                for (int i = 1; i <= n; i++) {

                    Console.WriteLine("");
                    Console.WriteLine($"Aluguel #{i}:");

                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());

                    vect[quarto] = new Aluguel { Name = name, Email = email, Quarto = quarto };

                }

                Console.WriteLine("");
                Console.WriteLine("Quartos ucupados:");
                for (int i = 0; i < OO; i++) {
                    if (vect[i] != null) {
                        Console.WriteLine($"{vect[i].Quarto}: {vect[i].Name}, {vect[i].Email}");
                    }
                }

            }
        }
    }
}
