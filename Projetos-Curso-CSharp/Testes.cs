using Projetos_Curso_CSharp.OO.Entities;
using Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine.Vetores.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp {
    internal class Testes {
        static void Main(string[] args) {

            string[] Nome;  //Vetor Nome
            int Qt = int.Parse(Console.ReadLine());
            int i = 0;
            Nome = new string[Qt];

            for (i = 0; i < Qt; i++) {
                Nome[i] = Console.ReadLine();

            }

            int aux = 0;

            foreach (string x in Nome) {
                Console.WriteLine($"Pos: {aux}, Nomes lidos: {x}");
                aux++;
            }

        }
    }
}