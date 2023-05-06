using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Structs.Foreach {
    public class Classe {
        internal class Class {
            public void Method() {

                string[] Nome;  //Vetor Nome
                int Qt = int.Parse(Console.ReadLine());
                int i = 0;
                Nome = new string[Qt];

                for (i = 0; i < Qt; i++) {
                    Nome[i] = Console.ReadLine();

                }

                foreach (string x in Nome) {
                    i++;
                    Console.WriteLine($"Pos: {i}, Nomes lidos: {x}");
                }

            }
        }
    }
}
