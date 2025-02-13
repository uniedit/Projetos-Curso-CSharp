using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class Class {
        public void Method() {

            Console.WriteLine("Bom dia!");
            string myoo = Console.ReadLine();
            string myuu = Console.ReadLine();
            string myii = Console.ReadLine();

            Console.WriteLine("Frase: " + myoo + " " + myuu + " " + myii);

            //string nyoo = Console.ReadLine();
            //string[] Sloth = nyoo.Split(' ');

            string[] Sloth = Console.ReadLine().Split(' ');

            string n1 = Sloth[0];
            string n2 = Sloth[1];
            string n3 = Sloth[2];

            Console.WriteLine("Palavra One: " + n1 + "\nPalravra Two: " + n2 + "\nPalavra Tree: " + n3);

        }
    }
}

