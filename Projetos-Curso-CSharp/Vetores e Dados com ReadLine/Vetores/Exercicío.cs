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
                Aluguel[] vect = new Aluguel[n];

                for (int i = 1; i <= n; i++) {

                    Console.WriteLine($"Aluguel #{i}:");

                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());

                    vect[i] = new Aluguel { Name = name, Email = email, Quarto = quarto };
                }

                if (vect[n] != null) {

                } else {
                    for (int i = 0; i < n; i++) {
                        Console.WriteLine($"Quartos ocupados: \n{vect[i].Quarto}: {vect[i].Name}, {vect[i].Email}");
                    }
                }



            }
        }
    }
}
