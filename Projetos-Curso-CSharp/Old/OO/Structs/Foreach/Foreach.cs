using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Structs.Foreach {
    public class Classe {
        internal class Class {
            public void Method() {

                string[] Nome;  // Vetor Nome
                int Qt = int.Parse(Console.ReadLine());  // Quantidade de vezes a repetir
                int i = 0;  // Auxiliar do for
                Nome = new string[Qt];  // Criar no vetor nome [Quantidades de vezes]

                for (i = 0; i < Qt; i++) {
                    Nome[i] = Console.ReadLine();  // Repete Qt vezes e coloca no Nome[] na posição [i]
                }

                int aux = 0;

                foreach (string x in Nome) {
                    Console.WriteLine($"Pos: {aux}, Nomes lidos: {x}");
                    aux++;
                }

            }
        }
    }
}
